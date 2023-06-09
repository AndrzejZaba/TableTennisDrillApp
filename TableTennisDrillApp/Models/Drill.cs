﻿using System;
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
        public string Name { get; }
        public TimeSpan DurationTime { get; }
        public TimeSpan BreakTime { get; }
        public PlayersNumber NumberOfPlayers { get; }
        public DrillAdvancementLevel AdvancementLevel { get; }
        public List<string>? KeyWords { get; }
        public List<string>? Description { get; }
        public List<string>? Images { get; }
        public List<string>? Videos { get; }

        public Drill(string name, TimeSpan durationTime, TimeSpan breakTime, PlayersNumber numberOfPlayers, DrillAdvancementLevel advancementLevel, List<string>? keyWords, List<string>? description, List<string?> images, List<string?> videos)
        {
            Name = name;
            DurationTime = durationTime;
            BreakTime = breakTime;
            NumberOfPlayers = numberOfPlayers;
            AdvancementLevel = advancementLevel;
            KeyWords = keyWords;
            Description = description;
            Images = images;
            Videos = videos;
        }

        public Drill()
        {
            Name = "NoDrill";
            DurationTime = TimeSpan.Zero;
            BreakTime = TimeSpan.Zero;
            NumberOfPlayers = PlayersNumber.Solo;
            AdvancementLevel = DrillAdvancementLevel.Beginner;
            KeyWords = new List<string>();
            Description = new List<string>();
            Images = new List<string> {"NoDrill.jpg" };
            Videos = new List<string>();
        }
    }
}
