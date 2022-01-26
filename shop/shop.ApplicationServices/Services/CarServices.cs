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

            var carId = await _context.Car
                .Include(x => x.ExistingFilePaths)
                .FirstOrDefaultAsync(x => x.Id == id);

            await _file.RemoveImages(photos);
            _context.Car.Remove(carId);
            await _context.SaveChangesAsync();

            return carId;
        }
        public async Task<Car> Add(CarDto dto)
        {
            Car car = new Car();

            car.Id = Guid.NewGuid();
            car.Brand = dto.Brand;
            car.Mark = dto.Mark;
            car.Engine = dto.Engine;
            car.Price = dto.Price;
            car.Amount = dto.Amount;
            car.ProdusedAt = dto.ProdusedAt;
            car.ModifedAt = dto.ModifedAt;
            car.CreatedAt = dto.CreatedAt;
            _file.ProcessUploadFile(dto, car);

            await _context.Car.AddAsync(car);
            await _context.SaveChangesAsync();

            return car;
        }
        public async Task<Car> Edit(Guid id)
        {
            var result = await _context.Car
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Car> Update(CarDto dto)
        {
            Car car = new Car();

            car.Id = dto.Id;
            car.Brand = dto.Brand;
            car.Mark = dto.Mark;
            car.Engine = dto.Engine;
            car.Price = dto.Price;
            car.Amount = dto.Amount;
            car.ProdusedAt = dto.ProdusedAt;
            car.ModifedAt = dto.ModifedAt;
            car.CreatedAt = dto.CreatedAt;
            _file.ProcessUploadFile(dto, car);

            _context.Car.Update(car);
            await _context.SaveChangesAsync();

            return car;
        }
    }
}
