using BmxShopService.Models;
using BmxShopService.Models.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BmxShopService.Controllers
{
    public class AccountController : Controller
    {
        private readonly ShopContext _context;
        public AccountController(ShopContext context)
        {
            _context = context;
        }

        [HttpPost("/signup")]
        public async Task<ActionResult<UserLogin>> PostUser(SignUpInfoClient newUser)
        {
            cryptPassword(newUser.Password, out string hashedPassword, out string salt);
            if(_context.User.Any(u => u.Email == newUser.Email))
            {
                return StatusCode((int)HttpStatusCode.Conflict, "Email уже используется"); ;
            }
            var user = new User
            {
                Email = newUser.Email, 
                Name = newUser.Name,
                LastName = newUser.LastName,
                Phone = newUser.Phone,
                Address = newUser.Address,
                
            };
            var userLogin = new UserLogin 
            { 
                Login = newUser.Email,
                Password = hashedPassword,
                Salt = salt,
                Role = newUser.Role,
            };
            _context.UserLogin.Add(userLogin);
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = user.Id }, user);
        }

        [HttpPost("/token")]
        public IActionResult Token(string username, string password)
        {
            var identity = GetIdentity(username, password);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid username or password." });
            }
            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromSeconds(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name,
                role = identity.Claims.Where(c => c.Type == "Role").Select(c => c.Value).SingleOrDefault(),
                userId = identity.Claims.Where(c => c.Type == "Id").Select(c => c.Value).SingleOrDefault()
            };
            return Json(response);
        }

        private ClaimsIdentity GetIdentity(string username, string password)
        {
            var person = _context.UserLogin.Where(u => u.Login == username).FirstOrDefault();
            if (person != null && equalsPassword(password, person.Password, person.Salt) == true)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role),
                    new Claim("Role", person.Role),
                    new Claim("Id", person.UserId.ToString())
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }
            return null;
        }

        private void cryptPassword(string password, out string passwordHash, out string salt)
        {
            using(var hmac = new HMACSHA512())
            {
                salt = Convert.ToBase64String(hmac.Key);
                passwordHash = Convert.ToBase64String(
                    hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
                );
            }
        }

        private bool equalsPassword(string password, string passwordHash, string passwordSalt)
        {
            using (var hmac = new HMACSHA512(Convert.FromBase64String(passwordSalt)))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(Convert.FromBase64String(passwordHash));
            }
        }

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
