using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.ViewModels.DrillContentViewModels
{
    public class DrillContentViewModel : ViewModelBase
    {
        private readonly Drill _drill;

        public List<string> Images { get; set; }
        public string ImageOne { get; set; }
        public ICollection<DescriptionLine> DrillDescription { get; set; }
        public TimeSpan DurationTime => _drill.DurationTime;

        public DrillContentViewModel(Drill drill)
        {
            _drill = drill;

            // TODO: Improve this code
            try
            {
                Images = drill.Images.ToList();
                if (File.Exists(@"C:\My_Projects\C#\TableTennisTraining\TableTennisDrillApp\TableTennisDrillApp\Images\" + Images.First()))
                {
                    Images = _drill.Images.Select(r => string.Concat(@"/TableTennisDrillApp;component/Images/", r)).ToList();
                
                    ImageOne = Images.First();
                } 
                else
                {
                    ImageOne = @"/TableTennisDrillApp;component/Images/nodrill.jpg";
                }
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
