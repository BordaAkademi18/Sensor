using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SensorMicroservice.Authentication
{
    public class TokenAssigner
    {
        public static string GetToken(string hwId)
        {
            var claims = new[] {
                new Claim("hwId",hwId)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dd%88*377f6d&f£$$£$FdddFF33fssDG^!3"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken("alesta.bordatech.com",
              "alesta.bordatech.com",
              claims,
              expires: DateTime.Now.AddMinutes(13),
              signingCredentials: creds);



            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
