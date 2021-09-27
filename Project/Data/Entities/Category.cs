using System.Collections.Generic;
namespace CosmoShop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SpaceObject> SpaceObjects { get; set; }
    }
}
