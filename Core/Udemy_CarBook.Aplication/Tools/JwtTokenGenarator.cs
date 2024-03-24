using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Dtos;
using Udemy_CarBook.Aplication.Features.Mediator.Results.AppUserResults;

namespace Udemy_CarBook.Aplication.Tools
{
    public class JwtTokenGenarator
    {
        public  static TokenReesponseDto GenareteToken(GetCheckAppUserQueryResult result)
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(result.Role))
            claims.Add(new Claim(ClaimTypes.Role, result.Role));

            claims.Add(new Claim(ClaimTypes.NameIdentifier,result.Id.ToString()));

            if (!string.IsNullOrWhiteSpace(result.UserName))
                claims.Add(new Claim("Username",result.UserName));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            var signinCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);

            JwtSecurityToken token = new JwtSecurityToken(issuer:JwtTokenDefaults.ValidIssuer,audience:JwtTokenDefaults.ValidAudience,claims:claims,notBefore:DateTime.UtcNow,expires:expireDate,signingCredentials:signinCredentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return new TokenReesponseDto(tokenHandler.WriteToken(token), expireDate);


        }
    }
}
