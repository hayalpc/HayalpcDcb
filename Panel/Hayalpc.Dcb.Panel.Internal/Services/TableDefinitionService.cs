﻿using Hayalpc.Dcb.Data;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using Hayalpc.Library.Log;
using Hayalpc.Library.Repository.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace Hayalpc.Dcb.Panel.Internal.Services
{
    public class TableDefinitionService : BaseService<TableDefinition>, ITableDefinitionService
    {
        public TableDefinitionService(IRepository<TableDefinition> repository, IHpLogger logger, IHpUnitOfWork<HpDbContext> unitOfWork, IMemoryCache memoryCache) :
            base(repository, logger, unitOfWork, memoryCache)
        {
        }

        public override TableDefinition BeforeAdd(TableDefinition model)
        {
            model.Namespace = model.GetType().Namespace;
            model.Assembly = model.GetType().Assembly.ToString();
            return base.BeforeAdd(model);
        }

        public override TableDefinition BeforeUpdate(TableDefinition model)
        {
            model.Namespace = model.GetType().Namespace;
            model.Assembly = model.GetType().Assembly.ToString();
            return base.BeforeAdd(model);
        }

    }
}
