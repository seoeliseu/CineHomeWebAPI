using System.ComponentModel.DataAnnotations;

namespace CineHome.Api.Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
