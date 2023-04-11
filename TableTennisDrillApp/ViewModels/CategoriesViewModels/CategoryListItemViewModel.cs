using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListItemViewModel : ViewModelBase
    {
        private CategoryListViewModel listViewModel;
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
                    listViewModel.SelectedCategories.Add(this);
                }
                else
                {
                    listViewModel.SelectedCategories.Remove(this);
                }
            }
        }

        public CategoryListItemViewModel(string categoryName, CategoryListViewModel listViewModel)
        {
            CategoryName = categoryName;
            this.listViewModel = listViewModel;
        }
    }
}
