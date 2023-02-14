using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayalpc.Dcb.Common.Dtos
{
    public class UserDataDto : Hayalpc.Library.Common.Dtos.UserDataDto
    {
        public List<SelectListItem> MerchantList { get; set; }
        public List<SelectListItem> ServiceList { get; set; }
        public List<SelectListItem> CarrierList { get; set; }
    }
}
