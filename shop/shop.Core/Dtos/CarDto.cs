using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;


namespace shop.Core.Dtos
{
    public class CarDto
    {
        public Guid? Id { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public double Engine { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime ProdusedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifedAt { get; set; }
        public List<IFormFile> Files { get; set; }
        public IEnumerable<ExistingFilePathDto> ExistingFilePaths { get; set; } = new List<ExistingFilePathDto>();
    }
}
