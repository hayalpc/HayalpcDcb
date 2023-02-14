using System.ComponentModel.DataAnnotations;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum CarrierCollectionStatus
    {
        [Display(Name = "Enum.Passive")]
        Passive = -1,
        [Display(Name = "Enum.Rejected")]
        Rejected = -10,
        [Display(Name = "Enum.New")]
        New = 0,
        [Display(Name = "Enum.Processing")]
        Processing = 1,
        [Display(Name = "Enum.ApprovePending")]
        ApprovePending = 2,
        [Display(Name = "Enum.CarrierPending")]
        CarrierPending = 3,
        [Display(Name = "Enum.CollectionActive")]
        Active = 5,
        [Display(Name = "Enum.PaymentPending")]
        PaymentPending = 7,
        [Display(Name = "Enum.Completed")]
        Completed = 10,
    }
}
