using System.ComponentModel.DataAnnotations;

namespace WEBAPI_DB_Crud.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string CatName { get; set; }
    }
}
