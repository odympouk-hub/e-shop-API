using System.ComponentModel.DataAnnotations;

namespace odysseasAPI.models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductShortName { get; set; } = string.Empty;
        public string LongName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string Desscriprion { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public float Price { get; set; }
        public string ThumbnailImage { get; set; } = string.Empty;
        public string IsInStock { get; set; } = string.Empty;
       
    }
}
