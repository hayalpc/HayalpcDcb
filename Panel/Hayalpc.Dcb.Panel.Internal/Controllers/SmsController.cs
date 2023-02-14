using System.Collections.Generic;
using Hayalpc.Library.Common.Results;
using Microsoft.AspNetCore.Mvc;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using DevExtreme.AspNet.Data;

namespace Hayalpc.Dcb.Panel.Internal.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ISmsService service;

        public SmsController(ISmsService service)
        {
            this.service = service;
        }

        [HttpGet("{id}")]
        public IDataResult<Sms> Get(long Id)
        {
            return service.Get(Id);
        }

        [HttpPost]
        public IDataResult<IEnumerable<Sms>> Search(DataSourceLoadOptionsBase req)
        {
            return service.Search(req);
        }

    }
}
