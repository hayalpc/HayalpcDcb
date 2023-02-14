using Hayalpc.Library.Common.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayalpc.Dcb.Common.Helpers 
{
    public class RequestHelper : Hayalpc.Library.Common.Helpers.RequestHelper
    {
        [ThreadStatic]
        public static long MerchantId = 0;
      
    }
}
