using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Panel.External.Resources;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class CategoryController : BaseController<CategoryVM, ICategoryService>
    {
        public CategoryController(ICategoryService service, LocService tr, ISessionHelper session, IHpLogger logger) : base(service, tr, session, logger)
        {
        }
    }
}
