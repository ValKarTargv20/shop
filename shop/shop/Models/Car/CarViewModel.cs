using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public DateTime ModifedAt { get; set; }
    }
}
