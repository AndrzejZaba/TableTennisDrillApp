using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TableTennisDrillApp.Commands;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.ViewModels.DrillsListViewModels
{
    public class DrillsListItemViewModel : ViewModelBase
    {
        private readonly DrillsListViewModel _drillsListViewModel;
        private readonly Drill? _drill;
        public Drill? StoredDrill => _drill;
        public string? DrillName => _drill.Name;
        public string? FirstImage { get; set; }
        public string? AdvancementLevel => _drill.AdvancementLevel.ToString();
        public ObservableCollection<string>? KeyWords { get; set; }

        public ICommand UpdateDrillContentCommand { get; }

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
                if (IsSelected)
                {
                    _drillsListViewModel.ActiveDrillStore.ActiveDrill = this.StoredDrill;
                }                
            }
        }

        public void GetKewords() => KeyWords = new ObservableCollection<string>(list: _drill.KeyWords);

        public DrillsListItemViewModel(Drill drill, DrillsListViewModel drillsListViewModel)
        {
            _drill = drill;
            GetKewords();
            _drillsListViewModel = drillsListViewModel;

            try
            {
                FirstImage = _drill.Images.Select(r => string.Concat(@"/TableTennisDrillApp;component/Images/", r)).First();

            }catch 
            {
                FirstImage = @"/TableTennisDrillApp;component/Images/nodrill.jpg";
            }

            UpdateDrillContentCommand = new UpdateDrillContentCommand(_drillsListViewModel.ActiveDrillStore);

        }
    }
}
