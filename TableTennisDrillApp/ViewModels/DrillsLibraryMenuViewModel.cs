using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.KeyWords;
using TableTennisDrillApp.ViewModels.CategoriesViewModels;

namespace TableTennisDrillApp.ViewModels
{
    public class DrillsLibraryMenuViewModel : ViewModelBase
    {
        public CategoryListViewModel CategoryListVM { get; }

        public DrillsLibraryMenuViewModel()
        {
            CategoryListVM = new CategoryListViewModel();
        }
    }
}
