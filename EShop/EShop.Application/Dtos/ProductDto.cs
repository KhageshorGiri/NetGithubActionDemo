using System.ComponentModel.DataAnnotations;

namespace EShop.Application.Dtos
{
    public class ProductDto
    {
        public Guid ID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class CreateProductDto
    {
        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }
    }

    public class UpdateProductDto
    {
        [Required]
        public string ItemName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }

}
