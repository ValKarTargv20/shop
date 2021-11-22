using shop.Data;
using shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shop.Core.ServiceInterface;
using shop.Core.Dtos;

namespace shop.ApplicationServices.Services
{
    public class ProductServices : IProductServices
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
                .FirstOrDefaultAsync(x => x.Id == id);

            _context.Product.Remove(productId);
            await _context.SaveChangesAsync();

            return productId;
        }
        public async Task<Product> Add(ProductDto dto)
        {
            var domain = new Product()
            {
                Id = dto.Id,
                Description = dto.Description,
                Name = dto.Name,
                Amount = dto.Amount,
                Price = dto.Price,
                ModifiedAt = DateTime.Now,
                CreatedAt = DateTime.Now
            };

            await _context.Product.AddAsync(domain);
            await _context.SaveChangesAsync();

            return domain;
        }

        public async Task<Product> Edit(Guid id)
        {
            var result = await _context.Product
                .FirstOrDefaultAsync(x => x.Id == id);

            var dto = new ProductDto();

            var domain = new Product()
            {
                Id = dto.Id,
                Description = dto.Description,
                Name = dto.Name,
                Amount = dto.Amount,
                Price = dto.Price,
                ModifiedAt = DateTime.Now,
                CreatedAt = dto.CreatedAt
            };

            return result;
        }
    }
    
}
