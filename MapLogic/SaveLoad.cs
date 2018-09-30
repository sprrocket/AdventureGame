using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using PlayerData;
using GameData;

namespace GameLogic
{
    public class SaveLoad
    {
        public static void SaveGame(string filePath)
        {
            string d = MapManager.CurrentRow + "\n" + MapManager.CurrentColumn;
            System.IO.File.WriteAllText(filePath, d);
        }
        public static void LoadGame(string filePath)
        {
            int c = 0;
            int[] i = new int[2];
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                i[c] = Int32.Parse(line);
                c++;
            }
            MapManager.SetRoomByIndex(i[0], i[1]);
            MapManager.CurrentRow = i[0];
            MapManager.CurrentColumn = i[1];
        }
    }
}
