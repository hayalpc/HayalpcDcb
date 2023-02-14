using Hayalpc.Dcb.Common.Models;
using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Library.Common.Results;

namespace Hayalpc.Dcb.Panel.External.Services.Interfaces
{
    public interface IUserService : IBaseService<UserVM>
    {
        IDataResult<SessionModel> Login(Library.Common.Models.LoginRequest request);
        void LoadBulletins();
        void LoadUserData();
    }
}
