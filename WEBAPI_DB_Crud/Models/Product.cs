using System.ComponentModel.DataAnnotations;

namespace WEBAPI_DB_Crud.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int CatId { get; set; }
    }
}
