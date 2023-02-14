using Hayalpc.Dcb.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayalpc.Dcb.Common.Helpers.Interfaces
{
    public interface ISessionHelper : Hayalpc.Library.Common.Helpers.Interfaces.ISessionHelper
    {
        new UserDto User { get; set; }
        new UserDataDto UserData { get; set; }

    }
}
