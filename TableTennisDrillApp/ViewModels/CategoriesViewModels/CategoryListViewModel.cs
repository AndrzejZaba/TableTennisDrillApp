using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.ViewModels.CategoriesViewModels
{
    public class CategoryListViewModel
    {
        public List<CategoryListItemViewModel> Categories { get; set; }

        public static CategoryListViewModel Instance => new CategoryListViewModel();

        public CategoryListViewModel()
        {
            Categories = new List<CategoryListItemViewModel>()
            {
                new CategoryListItemViewModel{
                    CategoryName ="FH" 
                },
                new CategoryListItemViewModel{
                    CategoryName ="BH" 
                },
                new CategoryListItemViewModel{
                    CategoryName ="Push" 
                },
                new CategoryListItemViewModel{
                    CategoryName ="Drive" 
                }
                ,new CategoryListItemViewModel{
                    CategoryName ="Serve" 
                },
              
            };
        }
    }
}
