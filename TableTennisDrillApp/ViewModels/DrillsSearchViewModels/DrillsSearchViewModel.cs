using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TableTennisDrillApp.Commands;
using TableTennisDrillApp.ViewModels.DrillsListViewModels;

namespace TableTennisDrillApp.ViewModels.SearachViewModels
{
    public class DrillsSearchViewModel : ViewModelBase
    {
        private readonly DrillsListViewModel _drillsListVM;

        private string _textToSearch;
        ICommand SearchDrillsByNameCommand;
        public string TextToSearch 
        { 
            get
            {
                return _textToSearch;
            }
            set
            {
                _textToSearch = value;
                OnPropertyChanged(nameof(TextToSearch));
                _drillsListVM.SelectDrillsByName(TextToSearch);
            }
        }

        

        public DrillsSearchViewModel(DrillsListViewModel drillsListVM)
        {
            _drillsListVM = drillsListVM;
            SearchDrillsByNameCommand = new SearchDrillsByNameCommand(_drillsListVM, TextToSearch);
        }


    }
}
