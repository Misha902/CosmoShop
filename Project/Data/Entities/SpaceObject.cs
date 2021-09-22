namespace CosmoShop.Data.Entities
{
    public class SpaceObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public ulong Price { get; set; }
        public string ImgId { get; set; }
        public string WeightShort { get; set; }
        public string WeightFull { get; set; }
        public string AgeShort { get; set; }
        public string AgeFull { get; set; }
        public int ObservedSatellites { get; set; }
        public string VolumeShort { get; set; }
        public string VolumeFull { get; set; }
        public double RotationPeriod { get; set; }
        public string PlanetarySystem { get; set; }
    }
}
