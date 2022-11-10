using BmxShopService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BmxShopService.Controllers
{
    public class AccountController : Controller
    {
        private readonly ShopContext _context;
        public AccountController(ShopContext context)
        {
            _context = context;
        }
        // тестовые данные вместо использования базы данных
        private List<UserLogin> people = new List<UserLogin>
        {
            new UserLogin {Login="admin@gmail.com", Password="12345", Role = "admin" },
            new UserLogin { Login="qwerty@gmail.com", Password="55555", Role = "user" }
        };

        [HttpPost("/signin")]
        public async Task<ActionResult<UserLogin>> PostUser(UserClient newUser)
        {
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
                Password = newUser.Password,
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
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name,
                role = identity.Claims.Where(c => c.Type == "Role").Select(c => c.Value).SingleOrDefault()
            };
            return Json(response);
        }

        private ClaimsIdentity GetIdentity(string username, string password)
        {
            var person = _context.UserLogin.Where(u => u.Login == username && u.Password == password).FirstOrDefault();
            if (person != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role),
                    new Claim("Role", person.Role)
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }

            // если пользователя не найдено
            return null;
        }


    }
}
