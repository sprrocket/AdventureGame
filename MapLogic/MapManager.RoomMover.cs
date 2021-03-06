﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameData;

namespace GameLogic
{
    public partial class MapManager
    {
        /// <summary>
        /// Handles the actual movement of updating the current room.
        /// </summary>
        /// <param name="newRoom"></param>
        /// <param name="oldRoom"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        private static LocationUpdateHelper MoveManager(Room newRoom, Room oldRoom, char dir)
        {
            if (newRoom != null && newRoom.Blocked != true)//if the newRoom is null, it's out of bounds
            {
                SetCurrentRoom(newRoom);
                newRoom.Discovered = true;
                PlayerManager.SetPlayerLocation(newRoom.Row, newRoom.Column);
                if (newRoom.HasNPC)
                {
                    PlayerInBattle = true;
                    newRoom.Description = "An NPC has appeared!";
                }
                return new LocationUpdateHelper(false);
            }
            else if (newRoom ==null){ return new LocationUpdateHelper(false);}//if it's out of bounds, it's not a blocked room
            else if (newRoom.Blocked == true)
            {
                newRoom.Discovered=true;
                return new LocationUpdateHelper(newRoom.Blocked, newRoom.Row, newRoom.Column);
            }
            else
            {
                throw new InvalidOperationException("Unexpected Room Update Event Occured.");
            }
        }

        /// <summary>
        /// Every time a directional button is pressed, the button's events are sent to this function
        /// to be sorted through to make sure the graphical map lines up with the one we have in memory.
        /// </summary>
        public static LocationUpdateHelper AttemptMove(string ButtonName)
        {
            Room r = GameData.GameData.CurrentRoom;
            switch (ButtonName)
            {
                case "northBtn":
                    return MoveManager(r.North, r, 'N');
                case "southBtn":
                    return MoveManager(r.South, r, 'S');
                case "eastBtn":
                    return MoveManager(r.East, r, 'E');
                case "westBtn":
                    return MoveManager(r.West, r, 'W');
                default:
                    throw (new InvalidOperationException("Invalid button event"));
            }
        }
    }
}
