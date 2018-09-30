using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GameData
{
    /// <summary>
    /// Acts as a virtual layout for the Rooms.
    /// </summary>
    [Serializable]
    public class Map
    {
        private Room[,] roomGrid = new Room[RoomData.RowsOfRooms, RoomData.ColumnsOfRooms];

        /// <summary>
        /// Inits the Map and connects the rooms that exist together
        /// </summary>
        public Map()
        {
            
            for (int r = 0; r < RoomData.RowsOfRooms; r++)
            {
                for (int c = 0; c < RoomData.ColumnsOfRooms; c++)
                {
                    roomGrid[r, c] = new Room();
                }
            }

            for (int r = 0; r < RoomData.RowsOfRooms; r++)
            {
                for (int c = 0; c < RoomData.ColumnsOfRooms; c++)
                {
                    roomGrid[r, c].ConnectRooms(FetchRoom(r - 1, c), FetchRoom(r + 1, c),
                                                  FetchRoom(r, c + 1), FetchRoom(r, c - 1));
                }
            }
        }

        /// <summary>
        /// Used by Map() to connect rooms
        /// </summary>
        /// <param name="r">row</param>
        /// <param name="c">column</param>
        /// <returns></returns>
        private Room FetchRoom(int r, int c)
        {
            if (r >= 0 && r < RoomData.RowsOfRooms && c >= 0 && c < RoomData.ColumnsOfRooms)
            {
                return roomGrid[r, c];
            }
            else return null;
        }

        public Room[,] RoomGrid { get { return roomGrid; } set { roomGrid = value; } }
    }
}