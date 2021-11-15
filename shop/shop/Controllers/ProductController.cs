using Microsoft.AspNetCore.Mvc;
using shop.Data;
using shop.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopDbContext _context;
        public ProductController
            (
            ShopDbContext context,
            IProduct
            )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Product
                .Select(x => new ProductListViewModel
                {
                    Id = x.Id,
                    Name= x.Name,
                    Price= x.Price,
                    Amount= x.Amount,
                    Desctiption= x.Desctiption,

                });
            return View(result);
        }

        public async Task<IActionResult> Delete(Guid id) 
        {
            return RedirectToAction(nameof(Index),product)
        
        }
    }
}
