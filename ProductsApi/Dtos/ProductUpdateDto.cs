using System.ComponentModel.DataAnnotations;

namespace ProductsApi.Dtos
{
    public class ProductUpdateDto
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [Range(0.00, double.MaxValue, ErrorMessage = "Price cannot be negative")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative")]
        public int Stock { get; set; }
    }
}