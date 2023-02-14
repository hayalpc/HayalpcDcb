using Hayalpc.Dcb.Common.Dtos;
using System.Collections.Generic;

namespace Hayalpc.Dcb.Common.Models
{
    public class SessionModel : Hayalpc.Library.Common.Models.SessionModel
    {
        public new UserDto User { get; set; }
    }
}
