using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisDrillApp.DTOs;
using TableTennisDrillApp.Enums;
using TableTennisDrillApp.Models;

namespace TableTennisDrillApp.Services.DrillsProviders
{
    public class DatabaseDrillsProvider : IDrillsProvider
    {
        IEnumerable<Drill> IDrillsProvider.GetAllDrills()
        {
            var connectionString = "Server=DESKTOP-B6CMF7A\\SQLEXPRESS;Database=TableTennisDrills;Trusted_Connection=True;encrypt=False;";
            var sqlQuery = "SELECT * FROM [TableTennisDrills].[dbo].[Drills]";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var drillsDTOs = connection.Query<DrillDTO>(sqlQuery);
                return drillsDTOs.Select(r => ToDrill(r)).ToList();
            }
        }

        private static Drill ToDrill(DrillDTO drillDTO)
        {
            return new Drill(
                drillDTO.DurationTime,
                drillDTO.BreakTime,
                (PlayersNumber)drillDTO.PlayersNumber,
                (DrillAdvancementLevel)drillDTO.AdvancementLevel,
                drillDTO.KeyWords?.Split(',').ToList(),
                drillDTO.Description?.Split(',').ToList(),
                drillDTO.Images?.Split(',').ToList(),
                drillDTO.Videos?.Split(',').ToList()
                );
        }
    }
}
