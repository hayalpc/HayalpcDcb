using System.ComponentModel.DataAnnotations;

namespace Hayalpc.Dcb.Common.Enums
{
    public class PlatformType
    {
        [Display(Name = "Enum.Renewal")]
        public static string RENEWAL = "renewal";
        [Display(Name = "Enum.API")]
        public static string API = "api";
        [Display(Name = "Enum.CP")]
        public static string CP = "cp";
        [Display(Name = "Enum.Landing")]
        public static string LND = "lnd";
        [Display(Name = "Enum.SMS")]
        public static string SMS = "sms";
    }
}