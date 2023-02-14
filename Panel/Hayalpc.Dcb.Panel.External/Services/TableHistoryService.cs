using Hayalpc.Library.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Panel.External.Models;

namespace Hayalpc.Dcb.Panel.External.Services
{
    [ServiceTypeAttr]
    public class TableHistoryService : BaseService<TableHistoryVM>, ITableHistoryService
    {
        public TableHistoryService(IHttpClientHelper clientHelper, IHpLogger logger) : base(clientHelper, logger,"tablehistory")
        {
        }
      
    }
}
