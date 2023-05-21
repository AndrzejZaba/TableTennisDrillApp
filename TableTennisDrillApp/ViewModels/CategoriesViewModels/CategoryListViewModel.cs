using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TableTennisDrillApp.KeyWords;
using TableTennisDrillApp.ViewModels.DrillsListViewModels;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CategoryListItemViewModel> _categories;
        private readonly List<string> _selectedCategories;
        public IEnumerable<CategoryListItemViewModel> Categories => _categories;
        public List<string> SelectedCategories => _selectedCategories;
        public List<string> KeyWords { get; set; }
        public DrillsListViewModel DrillsListVM { get; set; }

        private bool _isCategoriesMenuActive;
        public bool IsCategoriesMenuActive
        {
            get
            {
                return _isCategoriesMenuActive;
            }
            set
            {
                _isCategoriesMenuActive = value;
                OnPropertyChanged(nameof(IsCategoriesMenuActive));
                if (_isCategoriesMenuActive == true)
                {
                    CategoriesMenuVisibility = Visibility.Visible;
                }
                else
                {
                    CategoriesMenuVisibility = Visibility.Collapsed;
                }
            }
        }

        public Visibility _categoriesMenuVisibility;
        public Visibility CategoriesMenuVisibility
        {
            get
            {
                return _categoriesMenuVisibility;
            }
            set
            {
                _categoriesMenuVisibility = value;
                OnPropertyChanged(nameof(CategoriesMenuVisibility));
            }
        }


        public CategoryListViewModel(DrillsListViewModel drillsListVM)
        {
            DrillsListVM = drillsListVM;
            _categories = new ObservableCollection<CategoryListItemViewModel>();
            _selectedCategories = new List<string>();
            KeyWords = new List<string>();
            GetListOfKeywords();
            PrepareCategories();

            _categoriesMenuVisibility= Visibility.Collapsed;
        }

        /// <summary>
        /// Creates a list of KeyWords which are strings from KeyWord.cs file
        /// </summary>
        public void GetListOfKeywords()
        {
            var list = typeof(KeyWord).GetFields().Select(x => x.GetValue(typeof(KeyWord))).ToList();

            foreach (var item in list)
            {
                KeyWords.Add(item.ToString());
            }
        }

        /// <summary>
        /// Creates a list of CategoryListItemViewModel objects from a list of KeyWords
        /// </summary>
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
