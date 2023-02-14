using System;

namespace Hayalpc.Dcb.Common.Dtos
{
    public class UserBulletinDto : Hayalpc.Library.Common.Dtos.UserBulletinDto
    {
        public long? MerchantId { get; set; } = 0;
    }
}
