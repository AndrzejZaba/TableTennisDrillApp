using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TableTennisDrillApp.Commands;
using TableTennisDrillApp.Models;
using TableTennisDrillApp.Stores;

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
                    ActiveDrillStore.GetStore().ActiveDrill = this.StoredDrill;
                }                
            }
        }

        public void GetKewords() => KeyWords = new ObservableCollection<string>(list: _drill.KeyWords);

        public DrillsListItemViewModel(Drill drill, DrillsListViewModel drillsListViewModel)
        {
            _drill = drill;
            GetKewords();
            _drillsListViewModel = drillsListViewModel;

            // TODO: Try to improve this code
            try
            {
                if (File.Exists($"{Directory.GetCurrentDirectory()}\\..\\..\\..\\Images\\{_drill.Images.First()}"))
                {
                    FirstImage = _drill.Images.Select(r => string.Concat(@"/TableTennisDrillApp;component/Images/", r)).First();
                }
                else
                {
                    FirstImage = @"/TableTennisDrillApp;component/Images/nodrill.jpg";
                }
            }
            catch 
            {
                FirstImage = @"/TableTennisDrillApp;component/Images/nodrill.jpg";
            }

            UpdateDrillContentCommand = new UpdateDrillContentCommand();

        }
    }
}
