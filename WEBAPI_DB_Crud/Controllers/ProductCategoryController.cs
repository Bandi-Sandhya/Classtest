using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WEBAPI_DB_Crud.Models;

namespace WEBAPI_DB_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductCategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public ActionResult Get()
        {
            var data = _context.CatWiseProducts.FromSqlInterpolated($"dbo.SP_ProductsCategory");
            return Ok(data);
        }
        [HttpGet]
        [Route("GetDetails/{id:int}")]



        public ActionResult GetDetails(int id)
        {
            var data = _context.CatWiseProducts.FromSqlInterpolated($"dbo.SP_ProductByCatId{id}");
            return Ok(data);

        }
    }
}

