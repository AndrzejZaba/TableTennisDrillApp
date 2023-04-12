using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.ViewModels.DrillsListViewModels
{
    public class DrillsListItemViewModel : ViewModelBase
    {
        private readonly Drill? _drill;
        public string? DrillName => _drill.NumberOfPlayers.ToString();
        public string? Image => _drill.Images?.First();
        public string? AdvancementLevel => _drill.AdvancementLevel.ToString();
        public ObservableCollection<string>? KeyWords { get; set; }

        private bool _isSelected = false;
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));

            }
        }

        public void GetKewords() => KeyWords = new ObservableCollection<string>(list: _drill.KeyWords);

        public DrillsListItemViewModel(Drill drill)
        {
            _drill = drill;
            GetKewords();
        }
    }
}
