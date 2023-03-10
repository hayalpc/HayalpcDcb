using Hayalpc.Library.Common.Models;
using Hayalpc.Library.Common.Results;
using Hayalpc.Dcb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hayalpc.Dcb.Common.Dtos;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IUserService : IBaseService<User>
    {
        List<UserBulletin> Bulletin();
        IDataResult<UserDataDto> Data();

        IDataResult<SessionModel> Login(LoginRequest request);
        IDataResult<User> Get(long Id, bool include = true);
        UserDto GetFromCache(long Id);
        Result ForgetPassword(string email);
        Result ResetPassword(long Id);
        Result AccountChangePassword(ChangePassword changePassword);
        Result Logout(long Id);
        Result UpdatePassword(PasswordRequest passwordRequest);
    }
}
