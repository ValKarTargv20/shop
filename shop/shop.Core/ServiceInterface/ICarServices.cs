using shop.Core.Domain;
using shop.Core.Dtos;
using System;
using System.Threading.Tasks;

namespace shop.Core.ServiceInterface
{
    public interface ICarServices : IApplicationService
    {
        Task<Car> Delete(Guid Id); //delete by ID
        Task<Car> Add(CarDto dto); //Add to Dto
        Task<Car> Edit(Guid Id); //edit by Id
        Task<Car> Update(CarDto dto); //Update to Dto

    }
}
