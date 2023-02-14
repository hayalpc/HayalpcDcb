using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum MerchantType
    {
        [Display(Name = "Enum.SahisSirket")]
        SahisSirket = 1,
        [Display(Name = "Enum.AnonimSirket")]
        AnonimSirket = 2,
        [Display(Name = "Enum.Dernek")]
        Dernek = 3,
        [Display(Name = "Enum.KamuKurulusu")]
        KamuKurulusu = 4,
        [Display(Name = "Enum.LimitedSirket")]
        LimitedSirket = 4,
        [Display(Name = "Enum.YabanciSirket")]
        YabanciSirket = 4,
        [Display(Name = "Enum.Other")]
        Other = 4,
    }
}
