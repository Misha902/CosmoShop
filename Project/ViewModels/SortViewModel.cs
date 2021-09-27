﻿using CosmoShop.Data.Entities;

namespace CosmoShop.ViewModels
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; }
        public SortState PriceSort { get; private set; }
        public SortState CategorySort { get; private set; }
        public SortState Current { get; private set; }

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            PriceSort = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;
            CategorySort = sortOrder == SortState.CategoryAsc ? SortState.CategoryDesc : SortState.CategoryAsc;
            Current = sortOrder;
        }
    }
}
