using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.ViewModels.CategoriesViewModels;

namespace TableTennisDrillApp.Commands
{
    public class UpdateSelectedCategoriesCommand : AsyncCommandBase
    {
        private readonly CategoryListViewModel _categoryListViewModel;

        public UpdateSelectedCategoriesCommand(CategoryListViewModel categoryListViewModel)
        {
            _categoryListViewModel = categoryListViewModel;
        }
        

        public override async Task ExecuteAsync(object? parameter)
        {
            _categoryListViewModel.DrillsListVM.DrillLibrary.Drills.Clear();

             _categoryListViewModel.DrillsListVM.DrillLibrary.Drills = await _categoryListViewModel.DrillsListVM.DrillLibrary.GetSelectedDrillsAsync(
                _categoryListViewModel.SelectedCategories);

            _categoryListViewModel.DrillsListVM.RefreshDrills();
        }
    }
}
