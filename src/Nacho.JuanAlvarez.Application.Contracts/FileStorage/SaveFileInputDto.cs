using System.ComponentModel.DataAnnotations;

namespace Nacho.JuanAlvarez.FileStorage
{
    public class SaveFileInputDto
    {
        public byte[] Content { get; set; }
        [Required]
        public string Name { get; set; }
    }
}