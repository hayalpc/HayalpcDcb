using Microsoft.AspNetCore.Mvc;

namespace Hayalpc.Dcb.Panel.External.Filters
{
    public class AccessFilterAttribute : TypeFilterAttribute
    {
        public AccessFilterAttribute() : base(typeof(AccessFilter))
        {
        }
    }
}
