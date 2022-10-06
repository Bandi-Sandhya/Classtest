using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WEBAPI_DB_Crud.Models;

namespace WEBAPI_DB_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(AppDbContext context)
        {
            _context = context;

        }
        public AppDbContext _context { get; }


        [HttpGet]
        public ActionResult get()
        {
            var data = _context.Products.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == id);
            return Ok(data);
        }

        //to insert new record in table
        [HttpPost]
        public ActionResult post(Product newproduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Products.Add(newproduct);
                _context.SaveChanges();
                return Ok();
            }


        }
        //to update record of products
        [HttpPut("{id}")]
        public ActionResult put(int? id, Product modifiedproduct)
        {
            if (id == null)
                return NotFound();
            else
            {
                var data = _context.Products.FirstOrDefault(p => p.ProductId == id);
                data.ProductName = modifiedproduct.ProductName;
                data.Price = modifiedproduct.Price;
                _context.SaveChanges();
                return Ok();
            }
        }

        //to delete record us httpdelete
        [HttpDelete("{id}")]
        public ActionResult delete(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var data = _context.Products.FirstOrDefault(p => p.ProductId == id);
                _context.Products.Remove(data);
                _context.SaveChanges();
                return Ok();

            }

        }
    }
}
    

