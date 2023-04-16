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
        /// <summary>
        /// Get all drills from database
        /// </summary>
        /// <returns>IEnumerable of Drill model objects</returns>
        public async Task<IEnumerable<Drill>> GetAllDrills()
        {
            var connectionString = "Server=DESKTOP-B6CMF7A\\SQLEXPRESS;Database=TableTennisDrills;Trusted_Connection=True;encrypt=False;";
            var sqlQuery = "SELECT * FROM [TableTennisDrills].[dbo].[Drills]";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var drillsDTOs = await connection.QueryAsync<DrillDTO>(sqlQuery);
                return drillsDTOs.Select(r => ToDrill(r)).ToList();
            }
        }

        /// <summary>
        /// Converts DrillDTO into Drill model
        /// </summary>
        /// <param name="drillDTO">DrillDTO object to be converted</param>
        /// <returns>Drill model object</returns>
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
