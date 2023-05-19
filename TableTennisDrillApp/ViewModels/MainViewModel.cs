using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TableTennisDrillApp.Stores;

namespace TableTennisDrillApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase? MenuViewModel { get; set; }
        public ViewModelBase ActiveDrillContentViewModel => ActiveDrillStore.GetStore().ActiveDrillViewModel;

        public Visibility _introductoryScreenVisibility;
        public Visibility IntroductoryScreenVisibility 
        { 
            get
            {
                return _introductoryScreenVisibility;
            }
            set
            {
                _introductoryScreenVisibility = value;
                OnPropertyChanged(nameof(IntroductoryScreenVisibility));
            }
        }

        public MainViewModel()
        {
            ActiveDrillStore.GetStore().ActiveDrillChanged += OnCurrentDrillViewModelChanged;
            IntroductoryScreenVisibility = Visibility.Visible;
        }

        private void OnCurrentDrillViewModelChanged()
        {
            OnPropertyChanged(nameof(ActiveDrillContentViewModel));
            IntroductoryScreenVisibility = Visibility.Collapsed;
        }
    }
}
