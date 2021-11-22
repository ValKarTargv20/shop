using shop.Core.Domain;
using shop.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.ServiceInterface
{
    public interface IProductServices
    {
        Task<Product> Delete(Guid id);

        Task<Product> Add(ProductDto dto);
    }
}
