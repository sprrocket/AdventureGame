using GameData;

namespace GameLogic
{
    /// <summary>
    /// Getters and Setters for the Map Manager
    /// </summary>
    public partial class MapManager
    {
        public static int GridRowSize { get { return RoomData.RowsOfRooms; } }
        public static int GridColumnSize { get { return RoomData.ColumnsOfRooms; } }
        public static string CurrentRoomName { get { return GameData.GameData.CurrentRoom.Name; } }
        public static string CurrentRoomDescription { get { return GameData.GameData.CurrentRoom.Description; } set { GameData.GameData.CurrentRoom.Description = value; } }
        public static int CurrentRow { get { return (int)GameData.GameData.CurrentRoom.Row; } set { GameData.GameData.CurrentRoom.Row = value; } }
        public static int CurrentColumn { get { return (int)GameData.GameData.CurrentRoom.Column; } set { GameData.GameData.CurrentRoom.Column = value; } }
        public static bool CurrentIsDiscovered { get { return GameData.GameData.CurrentRoom.Discovered; } }
        public static bool PlayerInBattle { get { return GameData.GameData.PlayerInBattle; } set { GameData.GameData.PlayerInBattle = value; } }
        public static bool GameOver { get { return GameData.GameData.GameOver; } }
        public static bool GameEnd { get { return GameData.GameData.GameEnd; } }


        /// <summary>
        /// A "setter" for the Current room, since it's a bit cumbersome to type out every time.
        /// </summary>
        /// <param name="newRoom"></param>
        public static void SetCurrentRoom(Room newRoom) { GameData.GameData.CurrentRoom = newRoom; }
        public static void SetRoomByIndex(int row, int col) { GameData.GameData.CurrentRoom = GameData.GameData.RoomGrid[row, col]; }
        public static void SetupGameData()
        {
            MapLoader.LoadMapData(GameData.GameData.ActiveMap);
            PlayerManager.LoadPlayerData();
        }

        public static Map PackageMap()
        {
            return GameData.GameData.ActiveMap;
        }
    }
}
