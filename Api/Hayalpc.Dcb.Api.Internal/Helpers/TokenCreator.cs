using Hayalpc.Library.Common.Helpers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Hayalpc.Dcb.Api.Internal.Helpers
{
    public class TokenCreator : ITokenCreator
    {
        public string CreateToken()
        {
            var token = CreateSecurityToken();

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private JwtSecurityToken CreateSecurityToken()
        {
            var token = new JwtSecurityToken(
               issuer: AppConfigHelper.JwtIssuer,
               audience: AppConfigHelper.JwtAudience,
               expires: DateTime.Now.AddMinutes(3),
               signingCredentials: CreateCredentials()
               //claims: CreateClaims(appUser, appUserRoles)
             );
            return token;
        }

        public SigningCredentials CreateCredentials()
        {
            var secretKey = AppConfigHelper.JwtSecurityKey;
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            return creds;
        }

        //private List<Claim> CreateClaims(AppUser appUser, List<AppRole> appUserRoles)
        //{
        //    var claims = new List<Claim>();

        //    claims.Add(new Claim(ClaimTypes.Sid, appUser.Id.ToString()));
        //    claims.Add(new Claim(ClaimTypes.Name, appUser.Username));
        //    claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.FullName));
        //    claims.Add(new Claim(ClaimTypes.Email, appUser.Email));
        //    if (appUserRoles != null && appUserRoles.Count > 0)
        //    {
        //        foreach (var userRole in appUserRoles)
        //        {
        //            claims.Add(new Claim(ClaimTypes.Role, userRole.Name.ToString()));
        //        }
        //    }
        //    return claims;
        //}
    }
}
