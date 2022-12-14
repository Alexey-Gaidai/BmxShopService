using BmxShopService.Models;
using BmxShopService.Models.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net;

namespace BmxShopService.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController: ControllerAbstract
    {
        private readonly ShopContext _context;
        public UserController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<string>> PutUser(UserInfoClient user, int id)
        {
            var ser = JsonConvert.SerializeObject(user);
            Console.WriteLine(ser);
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }

            var newInfo = new User
            {
                Id = user.Id,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                UserImage = user.UserImage,
                Phone = user.Phone,
            };

            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(newInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode((int)HttpStatusCode.OK);
        }
        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
