using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Library.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hayalpc.Dcb.Panel.External.Models
{
    public class MerchantPaymentCalculateVM : BaseVM
    {
        public long[] MerchantId { get; set; }

    }
}
