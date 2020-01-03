using System;
using System.ComponentModel.DataAnnotations;

namespace CineHome.Api.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        private DateTime? _createdAt;
        public DateTime? CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = (value == null ? DateTime.UtcNow : value); }
        }

    }
}
