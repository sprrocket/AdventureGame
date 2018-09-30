using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData
{
    /// <summary>
    /// Holds the actively used information during runtime for the interactive map
    /// </summary>
    public static class GameData
    {
        private static Map activeMap = new Map();
        private static Room[,] roomGrid = activeMap.RoomGrid;
        private static Room currentRoom = roomGrid[3, 1];//3,1 is where the player begins

        public static Map ActiveMap { get { return activeMap; } }
        public static Room[,] RoomGrid { get { return roomGrid; } }
        public static Room CurrentRoom { get { return currentRoom; } set { currentRoom = value; } }
    }
}
