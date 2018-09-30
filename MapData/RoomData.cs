using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameData
{
    /*Room Layout
     *  □ x □
     *  x x x
     *  x x x
     *  □ x □  <-starting at the bottom x. □'s are blocked off.
     */

    /// <summary>
    /// The string literal in this class will hold all of the information needed for the rooms in the training simulator.
    /// This may be moved to an external file at a later sprint.
    /// We'll be using RegEx, so keep the formatting exact! This includes whitespace in the IDE.
    /// Numbers are formatted as row,column
    /// The format for each room is {row, column}, {NameOfRoom}, {RoomDescription}, {HasNPC(true/false)}
    /// </summary>
    public static class RoomData
    {
        private const int ROWS_OF_ROOMS = 4;
        private const int COLUMNS_OF_ROOMS = 3;
        public static Regex dataRegex = new Regex(@"{(\d+), (\d+)}, {(.+)}, {(.+)}, {(.+)}");
        public const string data =
@"
{3, 1}, {Entrance}, {Welcome, Adventurer!}, {false}

{2, 0}, {Empty Room}, {An empty room. How boring.}, {false}
{2, 1}, {Empty Room}, {An empty room. How boring.}, {false}
{2, 2}, {Empty Room}, {An empty room. How boring.}, {false}

{1, 0}, {Empty Room}, {An empty room. How boring.}, {false}
{1, 1}, {Empty Room}, {An empty room. How boring.}, {false}
{1, 2}, {Empty Room}, {An empty room. How boring.}, {false}

{0, 1}, {Empty Room}, {An empty room. How boring.}, {true}";
        public static int RowsOfRooms { get { return ROWS_OF_ROOMS; } }
        public static int ColumnsOfRooms { get { return COLUMNS_OF_ROOMS; } }
    }
}
