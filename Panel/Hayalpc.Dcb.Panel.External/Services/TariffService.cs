using Hayalpc.Library.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Panel.External.Models;

namespace Hayalpc.Dcb.Panel.External.Services
{
    public class TariffService : BaseService<TariffVM>, ITariffService
    {
        public TariffService(IHttpClientHelper clientHelper, IHpLogger logger) : base(clientHelper, logger,"tariff")
        {
        }
      
    }
}
