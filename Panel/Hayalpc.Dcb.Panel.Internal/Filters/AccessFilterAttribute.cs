using Microsoft.AspNetCore.Mvc;

namespace Hayalpc.Dcb.Panel.Internal.Filters
{
    public class AccessFilterAttribute : TypeFilterAttribute
    {
        public AccessFilterAttribute() : base(typeof(AccessFilter))
        {
        }
    }
}
