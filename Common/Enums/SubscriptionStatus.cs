using System.ComponentModel.DataAnnotations;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum SubscriptionStatus
    {
        [Display(Name = "Enum.New")]
        NEW = 1,
        [Display(Name = "Enum.RETRY")]
        RETRY = 2,
        [Display(Name = "Enum.Active")]
        ACTIVE = 3,
        [Display(Name = "Enum.SUSPEND")]
        SUSPEND = 4,
        [Display(Name = "Enum.REJECT")]
        REJECT = 5,
        [Display(Name = "Enum.Cancelled")]
        CANCEL = 6,
        [Display(Name = "Enum.UNDEFINED")]
        UNDEFINED = 10,
        [Display(Name = "Enum.FREE_TRIAL")]
        FREE_TRIAL = 15,
        [Display(Name = "Enum.INTERNAL_ERROR")]
        INTERNAL_ERROR = 20,
    }
}