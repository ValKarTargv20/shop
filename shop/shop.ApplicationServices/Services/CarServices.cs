using System;
using System.Linq;
using System.Threading.Tasks;
using shop.Core.ServiceInterface;
using shop.Data;
using shop.Core.Domain;
using shop.Core.Dtos;
using Microsoft.EntityFrameworkCore;


namespace shop.ApplicationServices.Services
{
    public class CarServices : ICarService
    {
        private readonly ShopDbContext _context;
        private readonly IFileServices _file;

        public CarServices
            (
            ShopDbContext context,
            IFileServices fileService
            )
        {
            _context = context;
            _file = fileService;
        }

        public async Task<Car> Delete(Guid id)
        {
            var photos = await _context.ExistingFilePath
                .Where(x => x.CarId == id)
                .Select(y => new ExistingFilePathDto
                {
                    CarId = y.CarId,
                    FilePath = y.FilePath,
                    PhotoId = y.Id
                })
                .ToArrayAsync();

            var CarId = await _context.Car
                .Include(x => x.ExistingFilePaths)
                .FirstOrDefaultAsync(x => x.Id == id);

            await _file.RemoveImages(photos);
            _context.Car.Remove(carId);
            await _context.SaveChangesAsync();

            return carId;
        }
        public Task<Car> Add(CarDto dto)
        {

        }
        public Task<Car> Edit(Guid id)
        {
            
        }

        public Task<Car> Update(CarDto dto)
        {
            
        }
    }
}
