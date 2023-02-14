using Hayalpc.Library.Common.Results;
using Hayalpc.Dcb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IServiceService : IBaseService<Service>
    {
        IDataResult<List<Service>> GetByMerchant(long Id);
    }
}
