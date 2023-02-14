using Hayalpc.Library.Common.Results;
using Hayalpc.Library.Log;
using Hayalpc.Library.Repository.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using Hayalpc.Dcb.Data;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Hayalpc.Dcb.Common.Helpers;
using Hayalpc.Dcb.Common.Enums;

namespace Hayalpc.Dcb.Panel.Internal.Services
{
    public class RoleService :BaseService<Role>, IRoleService
    {

        public RoleService(IRepository<Role> repository, IHpLogger logger, IHpUnitOfWork<HpDbContext> unitOfWork, IMemoryCache memoryCache)
            : base(repository,logger,unitOfWork,memoryCache)
        {
        }

        public override Role AfterAdd(Role model)
        {
            ClearCache();
            
            return model;
        }

        public override Role AfterUpdate(Role model)
        {
            ClearCache();

            return model;
        }

        public List<Role> GetAll() => memoryCache.GetOrCreate("RoleGetAll", entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(60);
            return repository.GetQuery(x => x.Status == Library.Common.Enums.Status.Active).ToList();
        });


        private void ClearCache(string kk = "")
        {
            memoryCache.Remove("RoleGetAll");
        }

        public override IQueryable<Role> BeforeSearch(IQueryable<Role> req)
        {
            if(RequestHelper.MerchantId > 0)
            {
                req = req.Where(x => 
                    (x.Type == UserType.MerchantUser ||
                    x.Type == UserType.MerchantAdmin ||
                    x.Type == UserType.MerchantAccounting)
                );
            }
            return base.BeforeSearch(req);
        }
    }
}
