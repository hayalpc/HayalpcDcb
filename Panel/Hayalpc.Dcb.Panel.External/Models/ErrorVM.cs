using System;

namespace Hayalpc.Dcb.Panel.External.Models
{
    public class ErrorVM : BaseVM
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
