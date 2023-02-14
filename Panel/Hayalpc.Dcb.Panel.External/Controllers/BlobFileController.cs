using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Library.Common.Dtos;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Common.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class BlobFileController : Controller
    {
        private readonly IBlobFileService service;
        private readonly ISessionHelper session;
        private readonly Library.Common.Helpers.Interfaces.IBlobStorageHelper storageHelper;

        public BlobFileController(IBlobFileService service, ISessionHelper session, Library.Common.Helpers.Interfaces.IBlobStorageHelper storageHelper)
        {
            this.service = service;
            this.session = session;
            this.storageHelper = storageHelper;
        }

        [AllowAnonymous]
        public IActionResult Get(Guid guid)
        {
            if (session.IsAuthenticated)
            {
                var blob = service.Get<DataResult<BlobFileDto>>($"blobFile/getByGuid/{guid}");
                if (blob.IsSuccess)
                {
                    var downloadInfo = storageHelper.Download(blob.Data.BlobUrl, blob.Data.AccountName,blob.Data.AccountKey);
                    if (downloadInfo.Success)
                    {
                        return File(downloadInfo.Stream, downloadInfo.ContentType, blob.Data.FileName);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
