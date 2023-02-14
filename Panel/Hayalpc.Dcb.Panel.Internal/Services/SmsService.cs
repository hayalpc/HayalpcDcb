using Hayalpc.Dcb.Data;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using Hayalpc.Library.Common.Helpers;
using Hayalpc.Library.Common.Results;
using Hayalpc.Library.Log;
using Hayalpc.Library.Repository.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;

namespace Hayalpc.Dcb.Panel.Internal.Services
{
    public class SmsService : BaseService<Sms>, ISmsService
    {
        public SmsService(IRepository<Sms> repository, IHpLogger logger, IHpUnitOfWork<HpDbContext> unitOfWork, IMemoryCache memoryCache)
            : base(repository, logger, unitOfWork, memoryCache)
        {
        }

        public override IDataResult<Sms> Add(Sms model) => throw new NotImplementedException();
        public override IDataResult<Sms> Update(Sms model) => throw new NotImplementedException();
        public override IDataResult<Sms> Update(Sms model, params string[] fields) => throw new NotImplementedException();

        public override IQueryable<Sms> BeforeSearch(IQueryable<Sms> req)
        {
            if (Dcb.Common.Helpers.RequestHelper.MerchantId > 0)
            {
                req = req.Where(x => x.MerchantId == Dcb.Common.Helpers.RequestHelper.MerchantId);
            }
            return base.BeforeSearch(req);
        }
    }
}
