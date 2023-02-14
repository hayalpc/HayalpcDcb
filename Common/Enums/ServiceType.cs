using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum ServiceType
    {
        [Display(Name = "Enum.Sub")]
        Sub = 1,

        [Display(Name = "Enum.Oneoff")]
        Oneoff = 2,
    }
}
