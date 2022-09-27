using System.ComponentModel.DataAnnotations;

namespace min.api.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string? HotTo { get; set; }

        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }
    }
}