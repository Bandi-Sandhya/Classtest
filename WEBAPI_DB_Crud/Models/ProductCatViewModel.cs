using System.ComponentModel.DataAnnotations;

namespace WEBAPI_DB_Crud.Models
{
    public class ProductCatViewModel
    {
        [Key]
        public int Productid { get; set; }
        public int CatId { get; set; }
        public string ProductName { get; set; }
        
        public decimal Price { get; set; }

        public string CatName { get; set; }
    }
}