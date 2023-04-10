using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListItemViewModel : ViewModelBase
    {
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
            }
        }

        public CategoryListItemViewModel(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
