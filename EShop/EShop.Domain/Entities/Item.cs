using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities
{
    public class Item : BaseEntity
    {
        [Required]
        public string? ItemName { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public decimal? Price { get; set; }
    }
}
