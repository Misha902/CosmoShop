using CosmoShop.Data.Entities;
using System.Collections.Generic;

namespace CosmoShop.Models
{
    public class PlanetarySystem : BaseProduct
    {
        
        public string RadiusShort { get; set; }
        public string RadiusFull { get; set; }
        
        public string Temperature { get; set; }
        public List<Planet> Planets { get; set; }
    }
}