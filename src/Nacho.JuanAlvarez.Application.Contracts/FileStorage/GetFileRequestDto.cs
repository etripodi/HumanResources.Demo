using System.ComponentModel.DataAnnotations;

namespace Nacho.JuanAlvarez.FileStorage
{
    public class GetFileRequestDto
    {
        [Required]
        public string Name { get; set; }
    }
}