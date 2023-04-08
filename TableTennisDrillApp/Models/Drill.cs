using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Enums;

namespace TableTennisDrillApp.Models
{
    public class Drill
    {
        public TimeSpan DurationTime { get; }
        public TimeSpan BreakTime { get; }
        public PlayersNumber NumberOfPlayers { get; }
        public DrillAdvancementLevel AdvancementLevel { get; }
        public List<string>? KeyWords { get; }
        public List<string>? Description { get; }
        public List<string?> Images { get; }
        public List<string?> Videos { get; }

        public Drill(TimeSpan durationTime, TimeSpan breakTime, PlayersNumber numberOfPlayers, DrillAdvancementLevel advancementLevel, List<string>? keyWords, List<string>? description, List<string?> images, List<string?> videos)
        {
            DurationTime = durationTime;
            BreakTime = breakTime;
            NumberOfPlayers = numberOfPlayers;
            AdvancementLevel = advancementLevel;
            KeyWords = keyWords;
            Description = description;
            Images = images;
            Videos = videos;
        }
    }
}
