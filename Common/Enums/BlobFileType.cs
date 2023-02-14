using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hayalpc.Dcb.Common.Enums
{
    public enum BlobFileType
    {
        [Display(Name = "ENUM.MerchantFile")]
        Merchant = 1,
        [Display(Name = "ENUM.ServiceFile")]
        Service = 2,
        [Display(Name = "ENUM.CollectionFile")]
        Collection = 3,
    }
}
