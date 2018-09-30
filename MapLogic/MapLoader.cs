using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MapData;

namespace MapLogic
{
    public class MapLoader
    {
        /// <summary>
        /// Attached the information from Data.RoomData to the map
        /// </summary>
        /// <param name="match"></param>
        /// <param name="activeMap"></param>
        private static void ParseMatch(Match match, Map activeMap)
        {
            int row = Int32.Parse(match.Groups[1].Value);
            int col = Int32.Parse(match.Groups[2].Value);
            activeMap.RoomGrid[row, col].Row = row;
            activeMap.RoomGrid[row, col].Column = col;
            activeMap.RoomGrid[row, col].Name = match.Groups[3].Value;
            activeMap.RoomGrid[row, col].Description = match.Groups[4].Value;
        }
        private static void ParseBlockedRooms(Map activeMap)
        {
            for (int row = 0; row < RoomData.RowsOfRooms; row++)
            {
                for (int col = 0; col < RoomData.ColumnsOfRooms; col++)
                {
                    if (activeMap.RoomGrid[row, col].Name == null)
                    {
                        activeMap.RoomGrid[row, col].Blocked = true;
                        activeMap.RoomGrid[row, col].Row = row;
                        activeMap.RoomGrid[row, col].Column = col;
                    }

                }
            }
        }

        /// <summary>
        /// Loads the Regular Expressions from the DAL and parses the room data
        /// </summary>
        ///
        public static void LoadMapData(Map map)
        {

            MatchCollection matches = RoomData.dataRegex.Matches(RoomData.data);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    ParseMatch(match, map);

                }
            }
            ParseBlockedRooms(map);
            map.RoomGrid[3, 1].Discovered = true;//Set the initial room to "discovered"
        }

        /// <summary>
        /// Sets up the interactive map's default map data
        /// </summary>
        public static void SetupGameData()
        {
            LoadMapData(GameData.ActiveMap);
        }
    }
}
