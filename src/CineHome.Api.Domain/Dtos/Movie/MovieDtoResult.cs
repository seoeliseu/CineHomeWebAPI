using System;

namespace CineHome.Api.Domain.Dtos.Movie
{
    public class MovieDtoResult
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string OriginalTitle { get; set; }
        public string NationalTitle { get; set; }
        public int DurationMinutes { get; set; }
        public short ReleaseYear { get; set; }
    }
}
