using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum UserType
    {
        [Display(Name = "User")]
        User = 0, 
        
        [Display(Name = "Admin")]
        Admin = 10,

        [Display(Name = "GeneralManager")]
        GeneralManager = 15,

        [Display(Name = "Operation")]
        Operation = 20,

        [Display(Name = "Accounting")]
        Accounting = 21,

        [Display(Name = "MerchantAdmin")]
        MerchantAdmin = 30,
        [Display(Name = "MerchantUser")]
        MerchantUser = 31,
        [Display(Name = "MerchantAccounting")]
        MerchantAccounting = 32,

        [Display(Name = "CallCenterAdmin")]
        CallCenter = 40,
        [Display(Name = "CallCenterAgent")]
        CallAgent = 41,
    }
}
