using Hayalpc.Library.Common.Results;
using Hayalpc.Dcb.Data.Models;
using System.Collections.Generic;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IRolePermissionService : IBaseService<RolePermission>
    {
        List<RolePermission> GetAll();
        List<RolePermission> GetByRoleId(long roleId);
        IResult Delete(long Id);
    }
}
