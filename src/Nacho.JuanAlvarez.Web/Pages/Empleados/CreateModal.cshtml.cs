using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nacho.JuanAlvarez.Empleados;
using Nacho.JuanAlvarez.FileStorage;

namespace Nacho.JuanAlvarez.Web.Pages.Empleados
{
    public class CreateModalModel : JuanAlvarezPageModel
    {
        [BindProperty]
        public UploadFileDto UploadFileDto { get; set; }
        public bool Uploaded { get; set; } = false;
        private readonly IFileAppService _fileAppService;
        
        [BindProperty]
        public CreateUpdateEmpleadoDto Empleado { get; set; }

        private readonly IEmpleadoAppService _empleadoAppService;

        public CreateModalModel(IEmpleadoAppService empleadoAppService, IFileAppService fileAppService)
        {
            _empleadoAppService = empleadoAppService;
            _fileAppService = fileAppService;
        }

        public void OnGet()
        {
            Empleado = new CreateUpdateEmpleadoDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await using (var memoryStream = new MemoryStream())
            {
                await UploadFileDto.File.CopyToAsync(memoryStream);

                await _fileAppService.SaveFileAsync(
                    new SaveFileInputDto
                    {
                        Name = UploadFileDto.Name,
                        Content = memoryStream.ToArray()
                    }
                );
            }
            
            await _empleadoAppService.CreateAsync(Empleado);
            
            return Page();
        }
    }

    public class UploadFileDto
    {
        [Required]
        [Display(Name = "Archivo")]
        public IFormFile File { get; set; }

        [Required]
        [Display(Name = "Nombre de archivo")]
        public string Name { get; set; }
    }
}