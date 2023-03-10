using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Panel.External.Resources;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Common.Dtos;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Common.Results;
using Hayalpc.Library.Log;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Hayalpc.Dcb.Common.Enums;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class MerchantController : BaseController<MerchantVM, IMerchantService>
    {
        private readonly Library.Common.Helpers.Interfaces.IBlobStorageHelper storageHelper;

        public MerchantController(IMerchantService service, LocService tr, ISessionHelper session, IHpLogger logger, Library.Common.Helpers.Interfaces.IBlobStorageHelper storageHelper) : base(service, tr, session, logger)
        {
            this.storageHelper = storageHelper;
        }

        public override MerchantVM BeforeUpdate(long id, MerchantVM model)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                var blobList = new List<BlobFileDto>();
                foreach (var formFile in files.GetFiles("files"))
                {
                    if (formFile.Length > 0)
                    {
                        var stream = new MemoryStream();
                        formFile.CopyTo(stream);

                        var guid = Guid.NewGuid();
                        var fileName = $"Merchant/{id}/{guid}_" + formFile.FileName;
                        var blobResult = storageHelper.Upload(stream, fileName);
                        if (blobResult.Success)
                        {
                            blobList.Add(new BlobFileDto
                            {
                                DataId = id,
                                Type = BlobFileType.Merchant,
                                Token = guid,
                                Name = formFile.FileName,
                                FileName = blobResult.FileName,
                                BlobUrl = blobResult.BlobUrl,
                                AccountName = blobResult.AccountName,
                                AccountKey = blobResult.AccountKey,
                                Status = Library.Common.Enums.Status.Active,
                                CreateUserId = session.User.Id,
                                CreateTime = DateTime.Now
                            });
                        }
                    }
                }
                if (blobList.Count > 0)
                {
                    var result = service.Post<List<BlobFileDto>, Result>("blobFile/addRange", blobList);
                }
            }
            return base.BeforeUpdate(id, model);
        }

        
    }
}
