using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
