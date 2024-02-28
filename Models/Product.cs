using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string? CategoryName { get; set; }
    }
}
