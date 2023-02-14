using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum TransactionStatus
    {
        [Display(Name = "Enum.New")]
        NEW = 1,
        [Display(Name = "Enum.Approved")]
        APPROVED = 2,
        [Display(Name = "Enum.Charged")]
        CHARGED = 3,
        [Display(Name = "Enum.Failed")]
        ERROR = 4,
        [Display(Name = "Enum.Timeout")]
        TIMEOUT = 5,
        [Display(Name = "Enum.Refunded")]
        REFUNDED = 6,
        [Display(Name = "Enum.UNDEFINED")]
        UNDEFINED = 10,
        [Display(Name = "Enum.FREE_TRIAL")]
        FREE_TRIAL = 15,
        [Display(Name = "Enum.INTERNAL_ERROR")]
        INTERNAL_ERROR = 20,
    }
}
