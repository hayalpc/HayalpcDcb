using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum RoleType 
    {
        [Display(Name = "Enum.User")]
        User = 0,

        [Display(Name = "Enum.Admin")]
        Admin = 10,

        [Display(Name = "Enum.Manager")]
        Manager = 15,

        [Display(Name = "Enum.Operation")]
        Operation = 20,

        [Display(Name = "Enum.Merchant")]
        Merchant = 30,

        [Display(Name = "Enum.CallCenter")]
        CallCenter = 40,
    }
}
