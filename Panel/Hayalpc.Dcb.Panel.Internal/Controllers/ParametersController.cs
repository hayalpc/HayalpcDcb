using DevExtreme.AspNet.Data;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using Hayalpc.Library.Common.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Hayalpc.Dcb.Panel.Internal.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class ParametersController : ControllerBase
    {
        private readonly IParametersService parametersService;

        public ParametersController(IParametersService parametersService)
        {
            this.parametersService = parametersService;
        }

        [HttpPost]
        public IDataResult<IEnumerable<Country>> Country(DataSourceLoadOptionsBase req)
        {
            return parametersService.Search<Country>(req);
        }

        [HttpPost]
        public IDataResult<IEnumerable<City>> City(DataSourceLoadOptionsBase req)
        {
            return parametersService.Search<City>(req);
        }

        [HttpPost]
        public IDataResult<IEnumerable<District>> District(DataSourceLoadOptionsBase req)
        {
            return parametersService.Search<District>(req);
        }
    }
}
