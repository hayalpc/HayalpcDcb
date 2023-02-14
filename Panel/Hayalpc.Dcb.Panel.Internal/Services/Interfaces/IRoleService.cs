using Hayalpc.Library.Common.Results;
using Hayalpc.Dcb.Data.Models;
using System.Collections.Generic;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IRoleService:IBaseService<Role>
    {
        List<Role> GetAll();
    }
}
