namespace CosmoShop.Data.Entities
{
    public class BaseProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public ulong Price { get; set; }
        public int ImgId { get; set; }
        public string WeightShort { get; set; }
        public string WeightFull { get; set; }
        public string AgeShort { get; set; }
        public string AgeFull { get; set; }
    }
}
