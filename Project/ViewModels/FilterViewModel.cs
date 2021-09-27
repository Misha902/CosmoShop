using CosmoShop.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CosmoShop.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Category> categories, int? category, string name)
{
            categories.Insert(0, new Category { Name = "All", Id = 0 });
            Categories = new SelectList(categories, "Id", "Name", category);
            SelectedName = name;
            CurrentCategory = category;
   
        }
        public SelectList Categories { get; private set; }
        public int? CurrentCategory { get; private set; }
        public string SelectedName { get; private set; }
    }
}
