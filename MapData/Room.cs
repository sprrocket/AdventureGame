using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData
{
    /// <summary>
    /// Data struct for each room
    /// </summary>
    public partial class Room
    {
        /// <summary>
        /// Variables for connected rooms
        /// Each room can be thought of as a "node"
        /// </summary>
        private Room north = null;
        private Room south = null;
        private Room east = null;
        private Room west = null;
        private int row;
        private int col;
        private bool discovered = false;
        private bool blocked = false;
        private bool hasNPC = false;
        private String name = null;
        private String description = null;

        /// <summary>
        /// default constructor
        /// </summary>
        public Room() { }

        /// <summary>
        /// Connects the rooms
        /// </summary>
        /// <param name="_north"></param>
        /// <param name="_south"></param>
        /// <param name="_east"></param>
        /// <param name="_west"></param>
        public void ConnectRooms(Room _north, Room _south, Room _east, Room _west)
        {
            this.north = _north;
            this.south = _south;
            this.east = _east;
            this.west = _west;
        }
    }
}
