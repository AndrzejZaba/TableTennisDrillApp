using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.ViewModels.DrillsListViewModels;

namespace TableTennisDrillApp.Commands
{
    class SearchDrillsByNameCommand : CommandBase
    {
        private readonly DrillsListViewModel _drillsListViewModel;
        private string _textToSearch;
        public SearchDrillsByNameCommand(DrillsListViewModel drillsListViewModel, string textToSearch)
        {
            _drillsListViewModel = drillsListViewModel;
            _textToSearch = textToSearch;
        }

        public override void Execute(object? parameter)
        {
            _drillsListViewModel.SelectDrillsByName(_textToSearch);
        }
    }
}
