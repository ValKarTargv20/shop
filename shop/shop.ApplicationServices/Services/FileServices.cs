using shop.Core.ServiceInterface;
using shop.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.Core.Dtos;
using shop.Core.Domain;
using System.IO;

namespace shop.ApplicationServices.Services
{
    public class FileServices : IFileServices
    {
        private readonly ShopDbContext _context;
        private readonly IWebHostEnvironment _env;

        public FileServices
            (
            ShopDbContext context,
            IWebHostEnvironment env
            )
        {
            _context = context;
            _env = env;
        }

        public async Task<ExistingFilePath> RemoveImage(ExistingFilePathDto dto)
        {
            var imageId = await _context.ExistingFilePath
                .FirstOrDefaultAsync(x => x.FilePath == dto.FilePath);

            string photoPath = _env.WebRootPath + "\\multipleFileUpload\\" + dto.FilePath;

            File.Delete(photoPath);

            _context.ExistingFilePath.Remove(imageId);
            await _context.SaveChangesAsync();

            return imageId;
        }

        public async Task<ExistingFilePath> RemoveImages(ExistingFilePathDto[] dto)
        {
            foreach (var dtos in dto)
            {
                var fileId = await _context.ExistingFilePath
                    .FirstOrDefaultAsync(x => x.FilePath == dtos.FilePath);

                string photoPath = _env.WebRootPath + "\\multipleFileUpload\\" + dtos.FilePath;

                File.Delete(photoPath);

                _context.ExistingFilePath.Remove(fileId);
                await _context.SaveChangesAsync();
            }
            return null;
        }

        public string ProcessUploadFile(CarDto dto, Car car)
        {
            string uniqueFileName = null;

            if(dto.Files !=null && dto.Files.Count >0)
            {
                if (!Directory.Exists(_env.WebRootPath + "\\multipleFileUpload\\"))
                {
                    Directory.CreateDirectory(_env.WebRootPath + "\\multipleFileUpload\\");
                }

                foreach (var photo in dto.Files)
                {
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "multipleFileUpload");
                    uniqueFileName = Guid.NewGuid().ToString() + " " + photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        photo.CopyTo(fileStream);

                        ExistingFilePath paths = new ExistingFilePath
                        {
                            Id = Guid.NewGuid(),
                            FilePath = uniqueFileName,
                            CarId = car.Id
                        };
                        _context.ExistingFilePath.Add(paths);
                    }
                }
            }
            return uniqueFileName;
        }
    }
}
