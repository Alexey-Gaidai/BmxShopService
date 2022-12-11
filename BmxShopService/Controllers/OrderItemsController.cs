using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BmxShopService;
using BmxShopService.Models;
using Newtonsoft.Json;
using BmxShopService.Models.Client;
using Microsoft.AspNetCore.Authorization;

namespace BmxShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerAbstract
    {
        private readonly ShopContext _context;

        public OrderItemsController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/OrderItems
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<OrderItems>>> GetOrderItemsById(int orderId)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            return await _context.OrderItems.Where(o => o.orderId == orderId).ToListAsync();
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<OrderItems>> GetOrderItems(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var orderItems = await _context.OrderItems.FindAsync(id);

            if (orderItems == null)
            {
                return NotFound();
            }

            return orderItems;
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOrderItems(int id, OrderItems orderItems)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            if (id != orderItems.id)
            {
                return BadRequest();
            }

            _context.Entry(orderItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemsExists(id))
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

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<OrderItems>> PostOrderItems(OrderItemClient[] orderItems)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) == false)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var items = new OrderItems[orderItems.Length];
            for (int i = 0; i < orderItems.Length; i++)
            {
                items[i] = new OrderItems
                {
                    productId = orderItems[i].ProductId,
                    productCount = orderItems[i].Count,
                    orderId = orderItems[i].OrderId
                };
            }
            _context.OrderItems.AddRange(items);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderItems", orderItems);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOrderItems(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var orderItems = await _context.OrderItems.FindAsync(id);
            if (orderItems == null)
            {
                return NotFound();
            }

            _context.OrderItems.Remove(orderItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderItemsExists(int id)
        {
            return _context.OrderItems.Any(e => e.id == id);
        }
    }
}
