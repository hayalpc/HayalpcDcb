﻿using Hayalpc.Dcb.Common.Helpers;
using Hayalpc.Dcb.Data;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using Hayalpc.Library.Common.Results;
using Hayalpc.Library.Log;
using Hayalpc.Library.Repository.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;

namespace Hayalpc.Dcb.Panel.Internal.Services
{
    public class SubscriptionService : BaseService<Subscription>, ISubscriptionService
    {
        public SubscriptionService(IRepository<Subscription> repository, IHpLogger logger, IHpUnitOfWork<HpDbContext> unitOfWork, IMemoryCache memoryCache)
            : base(repository, logger, unitOfWork, memoryCache)
        {
        }
        public override IDataResult<Subscription> Update(Subscription model) => throw new NotImplementedException();
        public override IDataResult<Subscription> Update(Subscription model, params string[] fields) => throw new NotImplementedException();

        public override IQueryable<Subscription> BeforeSearch(IQueryable<Subscription> req)
        {
            if (RequestHelper.MerchantId > 0)
            {
                req = req.Where(x => x.MerchantId == RequestHelper.MerchantId);
            }
            return base.BeforeSearch(req);
        }
    }
}
