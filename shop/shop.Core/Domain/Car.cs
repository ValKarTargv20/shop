using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Domain
{
    public class Car
    {
        public Guid? Id { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public double Engine { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateTime ProdusedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifedAt { get; set; }
    }
}
