using CosmoShop.Data.Entities;
using System.Collections.Generic;

namespace CosmoShop.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<SpaceObject> SpaceObjects { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        //public SortViewModel SortViewModel { get; set; }
    }
}
