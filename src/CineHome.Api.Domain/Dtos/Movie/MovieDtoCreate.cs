using System.ComponentModel.DataAnnotations;

namespace CineHome.Api.Domain.Dtos.Movie
{
    public class MovieDtoCreate
    {
        [Required(ErrorMessage = "Título original é um campo obrigatório")]
        [StringLength(255, ErrorMessage = "Título original deve ter no máximo {1} caracteres")]
        public string OriginalTitle { get; set; }
        public string NationalTitle { get; set; }
        public int DurationMinutes { get; set; }
        public short ReleaseYear { get; set; }
    }
}
