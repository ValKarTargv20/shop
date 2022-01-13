using shop.Data;
using shop.Core.Domain;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shop.Core.ServiceInterface;
using shop.Core.Dtos;
using System.Linq;

namespace shop.ApplicationServices.Services
{
    public class ProductServices : IProductService
    {
        private readonly ShopDbContext _context;
        private readonly IFileServices _file;

        public ProductServices
            (
            ShopDbContext context,
            IFileServices file
            )
        {
            _context = context;
            _file = file;
        }
        public async Task<Product> Delete(Guid id)
        {
            var photos = await _context.ExistingFilePaths
                .Where(x => x.ProductId == id)
                .Select(y => new ExistingFilePathDto
                {
                    ProductId = y.ProductId,
                    FilePath = y.FilePath,
                    PhotoId = y.Id
                })
                .ToArrayAsync();

            var productId = await _context.Product
                .Include(x => x.ExistingFilePaths)
                .FirstOrDefaultAsync(x => x.Id == id);

            await _file.RemoveImages(photos);
            _context.Product.Remove(productId);
            await _context.SaveChangesAsync();

            return productId;
        }
        public async Task<Product> Add(ProductDto dto)
        {
            Product product = new Product();

            product.Id = Guid.NewGuid();
            product.Description = dto.Description;
            product.Name = dto.Name;
            product.Amount = dto.Amount;
            product.Price = dto.Price;
            product.ModifiedAt = DateTime.Now;
            product.CreatedAt = DateTime.Now;
            _file.ProcessUploadFile(dto, product);

            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> Edit(Guid id)
        {
            var result = await _context.Product
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Product> Update(ProductDto dto)
        {
            Product product = new Product();

            product.Id = Guid.NewGuid();
            product.Description = dto.Description;
            product.Name = dto.Name;
            product.Amount = dto.Amount;
            product.Price = dto.Price;
            product.ModifiedAt = dto.ModifiedAt;
            product.CreatedAt = dto.CreatedAt;
            _file.ProcessUploadFile(dto, product);

            _context.Product.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
    
}
