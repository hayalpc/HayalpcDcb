using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hayalpc.Library.Common.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hayalpc.Dcb.Data.Models;
using Hayalpc.Dcb.Panel.Internal.Services;

namespace Hayalpc.Dcb.Panel.Internal.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        private readonly IResetPasswordService resetPasswordService;

        public ResetPasswordController(IResetPasswordService resetPasswordService)
        {
            this.resetPasswordService = resetPasswordService;
        }

        [HttpGet("{token}")]
        [AllowAnonymous]
        public IDataResult<ResetPassword> GetByToken(Guid token)
        {
            return resetPasswordService.GetByToken(token);
        }
    }

}
