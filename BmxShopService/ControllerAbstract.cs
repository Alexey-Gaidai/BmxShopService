using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace BmxShopService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerAbstract : ControllerBase
    {
        protected bool Validation(string? token)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var key = Encoding.ASCII.GetBytes(AuthOptions.KEY);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
