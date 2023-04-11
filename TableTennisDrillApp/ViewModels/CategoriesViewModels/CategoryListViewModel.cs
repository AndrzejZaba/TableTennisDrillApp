using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.KeyWords;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CategoryListItemViewModel> _categories;
        private readonly ObservableCollection<CategoryListItemViewModel> _selectedCategories;
        public IEnumerable<CategoryListItemViewModel> Categories => _categories;
        public ICollection<CategoryListItemViewModel> SelectedCategories => _selectedCategories;

        public List<string> KeyWords { get; set; }
        public CategoryListViewModel()
        {
            _categories = new ObservableCollection<CategoryListItemViewModel>();
            _selectedCategories = new ObservableCollection<CategoryListItemViewModel>();
            GetListOfKeywords();
            PrepareCategories();
        }

        public void GetListOfKeywords()
        {
            KeyWords = new List<string>();
            var list = typeof(KeyWord).GetFields().Select(x => x.GetValue(typeof(KeyWord))).ToList();

            foreach (var item in list)
            {
                KeyWords.Add(item.ToString());
            }
        }

        public void PrepareCategories()
        {
            foreach (var keyWord in KeyWords) 
            {
                CategoryListItemViewModel category = new CategoryListItemViewModel(keyWord, this);
                _categories?.Add(category);
            }
        }
    }
}
