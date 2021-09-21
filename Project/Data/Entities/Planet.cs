using CosmoShop.Data.Entities;

namespace CosmoShop.Models
{
    public class Planet : BaseProduct
    {
        public int ObservedSatellites { get; set; }
        public string VolumeShort { get; set; }
        public string VolumeFull { get; set; }
        public decimal RotationPeriod { get; set; }
        public PlanetarySystem PlanetarySystem { get; set; }
    }
}
