using System;
using System.Collections.Generic;
using System.Linq;
using Hayalpc.Library.Common.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Hayalpc.Dcb.Api.Internal.Controllers.v1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class DefaultController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        [Route("test", Name = nameof(Test))]
        public string Test()
        {
            return AppConfigHelper.JwtSecurityKey;
        }

        [HttpGet(Name = nameof(Get))]
        public IEnumerable<object> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new 
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("{id:long}", Name = nameof(Detail))]
        public object Detail(long id)
        {
            var rng = new Random();
            return Enumerable.Range(0, 1).Select(index => new 
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[id]
            }).FirstOrDefault();
        }

        [HttpPost(Name = nameof(Add))]
        public ActionResult Add()
        {
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}", Name = nameof(Update))]
        public ActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}", Name = nameof(Delete))]
        public ActionResult Delete()
        {
            return Ok();
        }

    }
}
