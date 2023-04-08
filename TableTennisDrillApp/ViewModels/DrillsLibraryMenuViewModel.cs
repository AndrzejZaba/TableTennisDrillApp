using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.KeyWords;

namespace TableTennisDrillApp.ViewModels
{
    public class DrillsLibraryMenuViewModel
    {
        public List<string> KeyWords { get; set; }
        public DrillsLibraryMenuViewModel()
        {
            KeyWords = new List<string>();
            var list = typeof(KeyWord).GetFields().Select(x => x.GetValue(typeof(KeyWord))).ToList();

            foreach (var item in list)
            {
                KeyWords.Add(item.ToString());
            }
        }
    }
}
