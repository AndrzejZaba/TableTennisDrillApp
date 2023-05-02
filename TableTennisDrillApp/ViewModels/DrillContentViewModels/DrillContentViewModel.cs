using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.ViewModels.DrillContentViewModels
{
    public class DrillContentViewModel : ViewModelBase
    {
        private readonly Drill _drill;

        public List<string> Images { get; set; }
        public string ImageOne => Images[0];
        public ICollection<DescriptionLine> DrillDescription { get; set; }
        public TimeSpan DurationTime => _drill.DurationTime;

        public DrillContentViewModel(Drill drill)
        {
            _drill = drill;
            try
            {
                Images = _drill.Images.Select(r => string.Concat(@"/TableTennisDrillApp;component/Images/", r)).ToList();

            }
            catch
            {
                Images = new List<string> { @"/TableTennisDrillApp;component/Images/nodrill.jpg" };
            }


            DrillDescription = new ObservableCollection<DescriptionLine>();
            foreach (var line in _drill.Description)
            {
                if (line.First().Equals('A'))
                {
                    DrillDescription.Add(new DescriptionLine(line.Remove(0,2), @"/TableTennisDrillApp;component/Icons/A_PlayerM.png"));
                }
                else
                {
                    DrillDescription.Add(new DescriptionLine(line.Remove(0,2), @"/TableTennisDrillApp;component/Icons/B_PlayerM.png"));
                }

            }
        }

        public DrillContentViewModel()
        {
            DrillDescription = new ObservableCollection<DescriptionLine>
            {
                new DescriptionLine("Test1", @"/TableTennisDrillApp;component/Icons/A_PlayerM.png"),
                new DescriptionLine("Test2", @"/TableTennisDrillApp;component/Icons/A_PlayerM.png"),
                new DescriptionLine("Test3", @"/TableTennisDrillApp;component/Icons/A_PlayerM.png")
            };
        }

    }

    public class DescriptionLine
    {
        public string Description { get; set; }
        public string PlayerIcon { get; set; }
        public DescriptionLine(string description, string playerIcon)
        {
            Description = description;
            PlayerIcon = playerIcon;
        }
    }
}
