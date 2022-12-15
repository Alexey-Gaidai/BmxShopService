using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BmxShopService.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using NuGet.Common;
using BmxShopService.Models.Client;

namespace BmxShopService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerAbstract
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var products = await _context.Products.ToListAsync();

            if (products == null && Validation(token))
            {
                return NotFound();
            }

            return products;
        }

        // GET: api/Products/5
        [HttpGet("{find}")]
        [Authorize]
        public async Task<ActionResult<List<Products>>> GetProducts(string find)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            find.ToLower();

            var products = await _context.Products.Where(p => 
                p.productName.ToLower().Contains(find) || 
                p.manufacturer.manufacturerName.ToLower().Contains(find) || 
                p.category.categoryName.ToLower().Contains(find)
            ).ToListAsync();

            if (products == null)
            {
                return NotFound();
            }
            if (Validation(token) != true)
            {
                return StatusCode((int)HttpStatusCode.Forbidden, "Время сеанса вышло. Зайдите в аккаунт заново.");
            }
            return products;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> PutProducts(int id, ProductClient product)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var products = new Products
            {
                id = product.Id,
                productName = product.productName,
                productDescription = product.productDescription,
                productPrice = product.productPrice,
                categoryId = product.categoryId,
                ManufacturerId = product.ManufacturerId,
                imageLink = product.imageLink,
            };
            if (id != products.id)
            {
                return BadRequest();
            }

            _context.Entry(products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Products>> PostProducts(ProductClient product)
        {
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var products = new Products
            {
                id = product.Id,
                productName = product.productName,
                productDescription = product.productDescription,
                productPrice = product.productPrice,
                categoryId = product.categoryId,
                ManufacturerId = product.ManufacturerId,
                imageLink = product.imageLink,
            };
            _context.Products.Add(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = products.id }, products);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteProducts(int id)
        {
                        var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (Validation(token) != true)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            _context.Products.Remove(products);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.id == id);
        }
    }
}
