using System.IO;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Nacho.JuanAlvarez.FileStorage
{
    public interface IFileAppService : IApplicationService
    {
        Task SaveFileAsync(SaveFileInputDto input);
        Task<FileDto> GetFileAsync(GetFileRequestDto input);
    }
}