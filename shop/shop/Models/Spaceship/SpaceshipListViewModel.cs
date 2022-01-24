using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models.Spaceship
{
    public class SpaceshipListViewModel : Controller
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Mass { get; set; }
        public decimal Price { get; set; }
        public int Crew { get; set; }
        public DateTime ConstructedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
