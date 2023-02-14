using System;
using System.Collections.Generic;
using System.IO;
using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Panel.External.Resources;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Common.Dtos;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Common.Results;
using Hayalpc.Library.Log;
using Microsoft.AspNetCore.Mvc;
using Hayalpc.Dcb.Common.Enums;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class ServiceController : BaseController<ServiceVM, IServiceService>
    {
        private readonly Library.Common.Helpers.Interfaces.IBlobStorageHelper storageHelper;
        public ServiceController(IServiceService service,LocService tr, ISessionHelper session, IHpLogger logger, Library.Common.Helpers.Interfaces.IBlobStorageHelper storageHelper) : base(service,tr, session, logger)
        {
            this.storageHelper = storageHelper;
        }

        public override ServiceVM BeforeUpdate(long id, ServiceVM model)
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
                        var fileName = $"Service/{id}/{guid}_" + formFile.FileName;
                        var blobResult = storageHelper.Upload(stream, fileName);
                        if (blobResult.Success)
                        {
                            blobList.Add(new BlobFileDto
                            {
                                DataId = id,
                                Type = BlobFileType.Service,
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

        public IActionResult BlobFile(Guid guid)
        {
            var blob = service.Get<DataResult<BlobFileDto>>($"blobFile/getByGuid/{guid}");
            if (blob.IsSuccess)
            {
                return Ok(blob.Data.BlobUrl);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
