using System;
using System.ComponentModel.DataAnnotations;

namespace CineHome.Api.Domain.Entities
{
    public class MovieEntity : BaseEntity
    {
        [Required]
        public string OriginalTitle { get; set; }
        public string NationalTitle { get; set; }
        public int DurationMinutes { get; set; }
        public short ReleaseYear { get; set; }
    }
}
