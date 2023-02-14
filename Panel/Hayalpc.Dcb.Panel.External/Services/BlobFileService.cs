using Hayalpc.Library.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Panel.External.Models;

namespace Hayalpc.Dcb.Panel.External.Services
{
    public class BlobFileService : BaseService<BlobFileVM>, IBlobFileService
    {
        public BlobFileService(IHttpClientHelper clientHelper, IHpLogger logger) : base(clientHelper, logger,"blobFile")
        {
        }
      
    }
}
