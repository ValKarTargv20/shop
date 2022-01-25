using shop.Core.Domain;
using shop.Core.Dtos;
using System.Threading.Tasks;

namespace shop.Core.ServiceInterface
{
    public interface IFileServices : IApplicationService
    {
        string ProcessUploadFile(CarDto dto, Car car);
        Task<ExistingFilePath> RemoveImage(ExistingFilePathDto dto);
        Task<ExistingFilePath> RemoveImages(ExistingFilePathDto[] dto);
    }
}
