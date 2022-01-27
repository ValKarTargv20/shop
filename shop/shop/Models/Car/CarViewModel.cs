using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using shop.Models.Files;

namespace shop.Models.Car
{
    public class CarViewModel
    {
        public Guid? Id { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public double Engine { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime ProdusedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public List<IFormFile> Files { get; set; }
        public List<ExistingFilePathViewModel> ExistingFilePaths { get; set; } = new List<ExistingFilePathViewModel>();
    }
}
