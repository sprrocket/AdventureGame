using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public partial class Room
    {
        public Room North { get { return north; } set { north = value; } }
        public Room South { get { return south; } set { south = value; } }
        public Room East { get { return east; } set { east = value; } }
        public Room West { get { return west; } set { west = value; } }
        public String Name { get { return name; } set { name = value; } }
        public String Description { get { return description; } set { description = value; } }
        public bool Discovered { get { return discovered; } set { discovered = value; } }
        public bool Blocked { get { return blocked; } set { blocked = value; } }
        public bool HasNPC { get { return hasNPC; } set { hasNPC = value; } }
        public int Row { get { return row; } set { row = value; } }
        public int Column { get { return col; } set { col = value; } }

    }
}
