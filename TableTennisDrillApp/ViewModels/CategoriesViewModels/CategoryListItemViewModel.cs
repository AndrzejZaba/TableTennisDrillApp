using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListItemViewModel
    {
        public string? CategoryName { get; set; } = "Bob";
        public bool IsChecked { get; set; } = false;

        public static CategoryListItemViewModel Instance => new CategoryListItemViewModel();


    }
}
