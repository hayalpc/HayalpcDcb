using Hayalpc.Dcb.Data.Models;
using Hayalpc.Library.Common.Results;

namespace Hayalpc.Dcb.Panel.Internal.Services.Interfaces
{
    public interface IUserBulletinService : IBaseService<UserBulletin>
    {
        IResult Read(long Id);
        IResult ReadAll();
    }
}
