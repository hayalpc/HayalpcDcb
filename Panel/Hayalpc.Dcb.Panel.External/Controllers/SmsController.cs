using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Panel.External.Resources;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Microsoft.AspNetCore.Mvc;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class SmsController : BaseController<SmsVM, ISmsService>
    {
        public SmsController(LocService tr, ISessionHelper session, IHpLogger logger, ISmsService service) : base(service,tr, session, logger)
        {
        }

        public override IActionResult Add() => NotFound();

        [HttpPost]
        public override IActionResult Add(SmsVM form) => NotFound();

        public override IActionResult Update(long id) => NotFound();

        [HttpPost]
        public override IActionResult Update(long id, SmsVM model) => NotFound();
    }
}
