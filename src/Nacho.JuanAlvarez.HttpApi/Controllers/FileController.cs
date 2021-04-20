using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nacho.JuanAlvarez.FileStorage;
using Volo.Abp.AspNetCore.Mvc;

namespace Nacho.JuanAlvarez.Controllers
{
    public class FileController : AbpController
    {
        private readonly IFileAppService _fileAppService;

        public FileController(IFileAppService fileAppService)
        {
            _fileAppService = fileAppService;
        }

        [HttpGet, Route("download/{fileName}")]
        public async Task<IActionResult> DownloadAsync(string fileName)
        {
            var fileDto = await _fileAppService.GetFileAsync(new GetFileRequestDto {Name = fileName});

            return File(fileDto.Content, "application/octet-stream", fileDto.Name);
        }
    }
}