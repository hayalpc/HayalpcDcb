using System.ComponentModel.DataAnnotations;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum SubscriptionType
    {
        [Display(Name = "Enum.Daily")]
        Daily,
        [Display(Name = "Enum.Weekly")]
        Weekly = 7,
        [Display(Name = "Enum.Montly")]
        Montly = 30,
    }
}