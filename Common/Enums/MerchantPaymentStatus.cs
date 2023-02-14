using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum MerchantPaymentStatus
    {
        [Display(Name = "Enum.Passive")]
        Passive = -1,
        [Display(Name = "Enum.Rejected")]
        Rejected = -10,
        [Display(Name = "Enum.New")]
        New = 0,
        [Display(Name = "Enum.Processing")]//ilk bundan başlayacak
        Processing = 1,
        [Display(Name = "Enum.ApprovePending")]//yükleyen yada biri onaylıyor
        ApprovePending = 2,
        [Display(Name = "Enum.ManagerPending")]//yönetici parayı onaylıyor
        CarrierPending = 3,
        [Display(Name = "Enum.TransferPending")]//ödeme yapılması bekleniyor
        Active = 5,
        [Display(Name = "Enum.Collected")]//para gönderildi
        Approved = 10,
    }
}
