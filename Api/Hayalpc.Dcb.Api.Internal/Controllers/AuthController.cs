using Hayalpc.Library.Common.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Hayalpc.Dcb.Api.Internal.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Hayalpc.Dcb.Api.Internal.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenCreator tokenCreator;

        public AuthController(ITokenCreator tokenCreator)
        {
            this.tokenCreator = tokenCreator;
        }

        [HttpPost]
        public IDataResult<string> Login()
        {

            //var userResult = userBusiness.Login(loginDto);
            //if (userResult.Success)
            //{
            //    var user = userResult.Data;
            //    var roles = userRoleBusiness.GetRolesByUserId(user.Id);
            //    if (roles.Success)
                    return new SuccessDataResult<string>(tokenCreator.CreateToken(), "Success");
            //    else
            //        return new ErrorDataResult<string>(401, "RolesNotFound");
            //}
            //else
            //{
            //    return new ErrorDataResult<string>(401, "UserNotFound");
            //}
        }

        [HttpGet]
        [Authorize]
        public IActionResult Validate()
        {
            //var user = userBusiness.GetByQuery(x => x.StatusId == Library.Repository.Status.Active && x.Username == User.Identity.Name).Data;
            //if (user != null)
            //{
            //    var roles = new List<string>();
            //    userRoleBusiness.GetRolesByUserId(user.Id).Data.ForEach((result)=> roles.Add(result.Name));
            //    var session = new SessionDto();
            //    session.User = mapper.Map<UserDto>(user);
            //    session.Roles = string.Join(",",roles.Select(x=>x.ToString()).ToArray());
            //    var res = new SuccessDataResult<SessionDto>(session);
            //    return Ok(res);
            //}
            return Ok();
            //return Unauthorized();
        }


    }
}
