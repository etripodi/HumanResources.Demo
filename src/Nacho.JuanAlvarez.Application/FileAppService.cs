using System.Threading.Tasks;
using Nacho.JuanAlvarez.FileStorage;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;

namespace Nacho.JuanAlvarez
{
    public class FileAppService : ApplicationService, IFileAppService
    {
        private readonly IBlobContainer<FileContainer> _fileContainer;

        public FileAppService(IBlobContainer<FileContainer> fileContainer)
        {
            _fileContainer = fileContainer;
        }

        public async Task SaveFileAsync(SaveFileInputDto input)
        {
            await _fileContainer.SaveAsync(input.Name, input.Content, true);
        }

        public async Task<FileDto> GetFileAsync(GetFileRequestDto input)
        {
           var requestedFile = await _fileContainer.GetAllBytesAsync(input.Name);

            return new FileDto
            {
                Name = input.Name,
                Content = requestedFile
            };
        }
    }
}