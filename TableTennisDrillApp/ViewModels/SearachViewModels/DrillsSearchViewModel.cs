using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisDrillApp.ViewModels.SearachViewModels
{
    public class DrillsSearchViewModel : ViewModelBase
    {
        private string _textToSearch;
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
            }
        }
    }
}
