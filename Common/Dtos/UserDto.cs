using Hayalpc.Dcb.Common.Enums;
using Hayalpc.Library.Common.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hayalpc.Dcb.Common.Dtos
{
    public class UserDto : Hayalpc.Library.Common.Dtos.UserDto
    {
        public new UserType Type { get; set; }
        public long? MerchantId { get; set; }
        public virtual bool IsMerchant { get { return MerchantId > 0; } }

        [NotMapped]
        public virtual MerchantDto Merchant { get; set; } = new MerchantDto();

        [NotMapped]
        public new virtual List<UserBulletinDto> Bulletins { get; set; }

    }
}
