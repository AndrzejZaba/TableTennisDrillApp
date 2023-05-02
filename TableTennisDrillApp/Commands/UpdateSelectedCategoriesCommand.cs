using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.ViewModels.CategoriesViewModels;

namespace TableTennisDrillApp.Commands
{
    public class UpdateSelectedCategoriesCommand : CommandBase
    {
        private readonly CategoryListViewModel _categoryListViewModel;

        public UpdateSelectedCategoriesCommand(CategoryListViewModel categoryListViewModel)
        {
            _categoryListViewModel = categoryListViewModel;
        }
        public override void Execute(object? parameter)
        {
            _categoryListViewModel.DrillsListVM.DrillLibrary.Drills = (IEnumerable<Models.Drill>)_categoryListViewModel.DrillsListVM.DrillLibrary.GetSelectedDrillsAsync(
                _categoryListViewModel.SelectedCategories);

            _categoryListViewModel.DrillsListVM.RefreshDrills();
        }
    }
}
