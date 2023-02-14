using Hayalpc.Dcb.Panel.External.Models;
using Hayalpc.Dcb.Panel.External.Resources;
using Hayalpc.Dcb.Panel.External.Services.Interfaces;
using Hayalpc.Dcb.Common.Helpers.Interfaces;
using Hayalpc.Library.Log;
using Microsoft.AspNetCore.Mvc;

namespace Hayalpc.Dcb.Panel.External.Controllers
{
    public class SubscriptionController : BaseController<SubscriptionVM, ISubscriptionService>
    {
        public SubscriptionController(LocService tr, ISessionHelper session, IHpLogger logger, ISubscriptionService service) : base(service,tr, session, logger)
        {
        }

        public override IActionResult Add() => NotFound();

        [HttpPost]
        public override IActionResult Add(SubscriptionVM form) => NotFound();

        public override IActionResult Update(long id) => NotFound();

        [HttpPost]
        public override IActionResult Update(long id, SubscriptionVM model) => NotFound();
    }
}
