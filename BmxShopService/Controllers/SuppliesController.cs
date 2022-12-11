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
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace BmxShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliesController : ControllerAbstract
    {
        private readonly ShopContext _context;

        public SuppliesController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/Deliveries
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Deliveries>>> GetDeliveries()
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) == false)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            else
            {
                return await _context.Deliveries.ToListAsync();
            }
        }

        // GET: api/Deliveries/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Deliveries>> GetDeliveries(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var deliveries = await _context.Deliveries.FindAsync(id);

            if (deliveries == null)
            {
                return NotFound();
            }

            return deliveries;
        }

        // PUT: api/Deliveries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutDeliveries(int id, Supplies sup)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var deliveries = new Deliveries
            {
                id = sup.id,
                productsId = sup.productsId,
                deliveryDate = sup.deliveryDate,
                productCount = sup.productCount,
            };
            if (id != deliveries.id)
            {
                return BadRequest();
            }

            _context.Entry(deliveries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode((int)HttpStatusCode.OK, "Время сеанса вышло. Зайдите в аккаунт заново."); ;
        }

        // POST: api/Deliveries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Deliveries>> PostDeliveries(Deliveries deliveries)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            _context.Deliveries.Add(deliveries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeliveries", new { id = deliveries.id }, deliveries);
        }

        // DELETE: api/Deliveries/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteDeliveries(int id)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var deliveries = await _context.Deliveries.FindAsync(id);
            if (deliveries == null)
            {
                return NotFound();
            }

            _context.Deliveries.Remove(deliveries);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeliveriesExists(int id)
        {
            return _context.Deliveries.Any(e => e.id == id);
        }
    }
}
