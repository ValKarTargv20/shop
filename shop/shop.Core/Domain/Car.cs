using System;
using System.Collections.Generic;

namespace shop.Core.Domain
{
    public class Car
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
        public IEnumerable<ExistingFilePath> ExistingFilePaths { get; set; } = new List<ExistingFilePath>();

    }
}
