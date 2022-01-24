using Microsoft.AspNetCore.Mvc;
using shop.Core.Dtos;
using shop.Core.ServiceInterface;
using shop.Data;
using shop.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class CarController : Controller
    {
        private readonly ShopDbContext _context;
        private readonly ICarServices _carService;

        public CarController
            (
            ShopDbContext context,
            ICarServices carService
            )
        {
            _context = context;
            _carService = carService;
        }
        public IActionResult Index()
        {
            var result = _context.Car
                .Select(x => new CarListViewModel
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Mark = x.Mark,
                    Engine = x.Engine,
                    Price = x.Price,
                    Amount = x.Amount
                });

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var car = await _carService.Delete(id);
            if (car == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index), car);
        }
           
        [HttpGet]
        public IActionResult Add()
        {
            CarViewModel model = new CarViewModel();
            return View("Edit", model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarViewModel model)
        {
            var dto = new CarDto()
            {
                Id = model.Id,
                Brand = model.Brand,
                Mark = model.Mark,
                Engine = model.Engine,
                Price = model.Price,
                Amount = model.Amount,
                ProdusedAt = model.ProdusedAt,
                CreatedAt = model.CreatedAt,
                ModifedAt = model.ModifedAt
            };
            var result = await _carService.Add(dto);
            if(result==null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var car = await _carService.Edit(id);
            if(car==null)
            {
                return NotFound();
            }

            var model = new CarViewModel();

            model.Id = car.Id;
            model.Brand = car.Brand;
            model.Mark = car.Mark;
            model.Engine = car.Engine;
            model.Price = car.Price;
            model.Amount = car.Amount;
            model.ProdusedAt = car.ProdusedAt;
            model.CreatedAt = car.CreatedAt;
            model.ModifedAt = car.ModifedAt;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CarViewModel model)
        {
            var dto = new CarDto()
            {
                Id = model.Id,
                Brand = model.Brand,
                Mark = model.Mark,
                Engine = model.Engine,
                Price = model.Price,
                Amount = model.Amount,
                ProdusedAt = model.ProdusedAt,
                CreatedAt = model.CreatedAt,
                ModifedAt = model.ModifedAt
            };
            var result = await _carService.Update(dto);
            if(result==null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index), model);
        }
    }
}
