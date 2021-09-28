using CosmoShop.Data.Entities;

namespace CosmoShop.ViewModels
{
    public class SortViewModel
    {
        public SortState PriceSort { get; private set; }
        public SortState Current { get; private set; }

        public SortViewModel(SortState sortOrder)
        {
            //PriceSort = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;
            //Current = sortOrder;
        }
    }
}
