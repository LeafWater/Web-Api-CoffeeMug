using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeeMug.Models;

namespace CoffeeMug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsContext _context;

        public ProductsController(ProductsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.Product.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(Guid id) {
            var product = _context.Product.Find(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }
            return product;
        }

        [HttpPost]
        public Guid PostProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        [HttpPut]
        public ActionResult PutProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest("Probably not all values are written (id, name, price).");
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(Guid id)
        {
            var product = _context.Product.Find(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }
            _context.Product.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
