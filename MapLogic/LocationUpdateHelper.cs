using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapLogic
{
    public class LocationUpdateHelper
    {
        public bool Blocked { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public LocationUpdateHelper() { }
        public LocationUpdateHelper(bool b) { Blocked = b; }
        public LocationUpdateHelper(bool b, int x, int y) { Blocked = b; Row = x; Column = y; }
    }
}
