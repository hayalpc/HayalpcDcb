using Hayalpc.Library.Common.Results;
using Microsoft.AspNetCore.Mvc;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services.Interfaces;
using System.Collections.Generic;
using DevExtreme.AspNet.Data;
using System;

namespace Hayalpc.Dcb.Panel.Internal.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarrierCollectionItemController : ControllerBase
    {
        private readonly ICarrierCollectionItemService service;

        public CarrierCollectionItemController(ICarrierCollectionItemService service)
        {
            this.service = service;
        }

        [HttpGet("{id}")]
        public IDataResult<CarrierCollectionItem> Get(long Id)
        {
            return service.Get(Id);
        }

        [HttpPost]
        public IDataResult<CarrierCollectionItem> Add(CarrierCollectionItem model)
        {
            return service.Add(model);
        }

        [HttpPost]
        public IDataResult<IEnumerable<CarrierCollectionItem>> Search(DataSourceLoadOptionsBase req)
        {
            return service.Search(req);
        }

        [HttpPost]
        public IResult AddRange(List<CarrierCollectionItem> models)
        {
            return service.AddRange(models);
        }

    }
}
