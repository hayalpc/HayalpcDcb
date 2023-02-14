using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum CarrierId
    {
        [Display(Name = "Enum.Turkcell")]
        Turkcell = 1,
        [Display(Name = "Enum.TurkTelekom")]
        TurkTelekom = 4,
        [Display(Name = "Enum.Vodafone")]
        Vodafone = 5
    }
}
