using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BmxShopService;
using BmxShopService.Models;
using BmxShopService.Models.Client;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace BmxShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerAbstract
    {
        private readonly ShopContext _context;

        public OrdersController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Orders>>> GetUserOrders(int userId)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            return await _context.Orders.Where(o => o.UserId == userId).ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Orders>> GetOrders(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var orders = await _context.Orders.FindAsync(id);

            if (orders == null)
            {
                return NotFound();
            }

            return orders;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOrders(int id, OrderClient newOrder)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var orders = new Orders
            {
                id = id,
                UserId = newOrder.UserId,
                purchaseDate = newOrder.purchaseDate,
                status = newOrder.status,
            };
            if (id != orders.id)
            {
                return BadRequest();
            }

            _context.Entry(orders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<int>> PostOrder(OrderClient newOrder)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var order = new Orders
            {
                UserId = newOrder.UserId,
                purchaseDate = newOrder.purchaseDate,
                status = newOrder.status,
            };
            Console.WriteLine($"1: {JsonConvert.SerializeObject(newOrder)}");
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return order.id;
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteOrders(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var orders = await _context.Orders.FindAsync(id);
            var orderItems = _context.OrderItems.Where(oi => oi.orderId == id).FirstOrDefault();
            if (orders == null)
            {
                return NotFound();
            }

            _context.OrderItems.RemoveRange(orderItems);
            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.id == id);
        }
    }
}
