using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nacho.JuanAlvarez.FileStorage;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Nacho.JuanAlvarez.Web.Pages.Empleados
{
    public class File : AbpPageModel
    {
        [BindProperty]
        public UploadFileDtos UploadFileDto { get; set; }

        private readonly IFileAppService _fileAppService;

        public bool Uploaded { get; set; } = false;

        public File(IFileAppService fileAppService)
        {
            _fileAppService = fileAppService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            using (var memoryStream = new MemoryStream())
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

            return Page();
        }
    }

    public class UploadFileDtos
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile File { get; set; }

        [Required]
        [Display(Name = "Filename")]
        public string Name { get; set; }
    }
}