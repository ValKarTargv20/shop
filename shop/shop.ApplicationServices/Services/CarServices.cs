using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using shop.Core.Domain;
using shop.Core.Dtos;
using shop.Core.ServiceInterface;
using shop.Data;
using System;
using System.Threading.Tasks;

namespace shop.ApplicationServices.Services
{
    public class CarServices : ICarServices
    {
        private readonly ShopDbContext _context;

        public CarServices
            (
            ShopDbContext context
            )
        {
            _context = context;
        }

        public async Task<Car> Delete(Guid id)
        {
            var carId = await _context.Car
                .FirstOrDefaultAsync(x => x.Id == id);

            _context.Car.Remove(carId);
            await _context.SaveChangesAsync();

            return carId;
        }

        public async Task<Car> Edit(Guid id)
        {
            var result = await _context.Car
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Car> Add(CarDto dto)
        {
            Car car = new Car();
            car.Id = dto.Id;
            car.Brand = dto.Brand;
            car.Mark = dto.Mark;
            car.Engine = dto.Engine;
            car.Price = dto.Price;
            car.Amount = dto.Amount;
            car.ProdusedAt = dto.ProdusedAt;
            car.CreatedAt = DateTime.Now;
            car.ModifedAt = DateTime.Now;

            await _context.Car.AddAsync(car);
            await _context.SaveChangesAsync();

            return car;
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
            car.CreatedAt = DateTime.Now;
            car.ModifedAt = DateTime.Now;

            await _context.Car.AddAsync(car);
            await _context.SaveChangesAsync();

            return car;
        }
    }
}
