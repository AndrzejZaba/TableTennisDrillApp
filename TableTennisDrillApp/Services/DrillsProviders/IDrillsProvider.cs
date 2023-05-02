﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.Services.DrillsProviders
{
    public interface IDrillsProvider
    {
        Task<IEnumerable<Drill>> GetAllDrillsAsync();
        Task<IEnumerable<Drill>> GetSelectedDrillsAsync(IEnumerable<string> selectedCategories);
    }
}
