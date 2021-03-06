using shop.Core.Domain;
using shop.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.ServiceInterface
{
    public interface IFileServices : IApplicationService
    {
        string ProcessUploadFile(ProductDto dto, Product product);
        Task<ExistingFilePath> RemoveImage(ExistingFilePathDto dto);
        Task<ExistingFilePath> RemoveImages(ExistingFilePathDto[] dto);
    }
}
