using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WEBAPI_DB_Crud.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //This model is imaginary table. not available in database. 
        //To catch data coming from stored procedure
        public DbSet<ProductCatViewModel> CatWiseProducts { get; set; }
    }
}
    

