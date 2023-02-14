using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Panel.External.Resources;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class TableDefinitionController : BaseController<TableDefinitionVM, ITableDefinitionService>
    {
        public TableDefinitionController(ITableDefinitionService service,LocService tr, ISessionHelper session, IHpLogger logger) : base(service,tr, session, logger)
        {
        }

    }
}
