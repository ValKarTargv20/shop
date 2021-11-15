using shop.Data;
using shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shop.Core.ServiceInterface;

namespace shop.ApplicationServices.Services
{
    public class ProductServices : IServiceInterface
    {
        private readonly ShopDbContext _context;
        public ProductServices
            (
            ShopDbContext context
            )
        {
            _context = context;
        }
        public async Task<Product> Delete(Guid id)
        {
            var productId = await _context.Product
                .FirstOrDefault(x => x.Id == id);

            _context.Product.Remove(productId);
            await _context.SaveChangesAsync();

            return productId;
        }
    }
    
}
