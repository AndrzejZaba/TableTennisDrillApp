using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TableTennisDrillApp.Commands;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListItemViewModel : ViewModelBase
    {
        private CategoryListViewModel _listViewModel;
        private string? _categoryName;
        public string? CategoryName
        {
            get 
            { 
                return _categoryName; 
            }
            set
            {
                _categoryName = value;
                OnPropertyChanged(nameof(CategoryName));
            }
        }
        
        private bool _isChecked = false;
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                OnPropertyChanged(nameof(IsChecked));

                if(_isChecked == true)
                {
                    _listViewModel.SelectedCategories.Add(this.CategoryName);
                }
                else
                {
                    _listViewModel.SelectedCategories.Remove(this.CategoryName);
                }
            }
        }

        public ICommand UpdateSelectedCategoriesCommand { get; }
        public CategoryListItemViewModel(string categoryName, CategoryListViewModel listViewModel)
        {
            CategoryName = categoryName;
            _listViewModel = listViewModel;
            UpdateSelectedCategoriesCommand = new UpdateSelectedCategoriesCommand(_listViewModel);
        }
    }
}
