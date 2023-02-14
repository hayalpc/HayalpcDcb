using Hayalpc.Dcb.Data;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using Hayalpc.Library.Common.Helpers;
using Hayalpc.Library.Log;
using Hayalpc.Library.Repository.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System.Linq;

namespace Hayalpc.Dcb.Panel.Internal.Services
{
    public class MerchantService : BaseService<Merchant>, IMerchantService
    {
        public MerchantService(IRepository<Merchant> repository, IHpLogger logger, IHpUnitOfWork<HpDbContext> unitOfWork, IMemoryCache memoryCache) :
            base(repository, logger, unitOfWork, memoryCache)
        {
        }

        public override Merchant BeforeGet(Merchant model)
        {
            var blobFiles = repository.GetQuery<BlobFile>(x => x.DataId == model.Id && x.Type == Dcb.Common.Enums.BlobFileType.Merchant && x.Status == Library.Common.Enums.Status.Active).ToList();
            if(blobFiles.Count > 0)
            {
                model.BlobFiles = blobFiles;
            } 
            return base.BeforeGet(model);
        }

        public override IQueryable<Merchant> BeforeSearch(IQueryable<Merchant> req)
        {
            if(Dcb.Common.Helpers.RequestHelper.MerchantId > 0)
            {
                req = req.Where(x => x.Id == Dcb.Common.Helpers.RequestHelper.MerchantId);
            }
            return base.BeforeSearch(req);
        }
        
    }
}
