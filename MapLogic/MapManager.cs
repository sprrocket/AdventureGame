using MapData;

namespace MapLogic
{
    /// <summary>
    /// Getters and Setters for the Map Manager
    /// </summary>
    public partial class MapManager
    {
        public static int GridRowSize { get { return RoomData.RowsOfRooms; } }
        public static int GridColumnSize { get { return RoomData.ColumnsOfRooms; } }
        public static string CurrentRoomName { get { return GameData.CurrentRoom.Name; } }
        public static string CurrentRoomDescription { get { return GameData.CurrentRoom.Description; } set { GameData.CurrentRoom.Description = value; } }
        public static int CurrentRow { get { return (int)GameData.CurrentRoom.Row; } }
        public static int CurrentColumn { get { return (int)GameData.CurrentRoom.Column; } }
        public static bool CurrentIsDiscovered { get { return GameData.CurrentRoom.Discovered; } }
        public static bool PlayerInBattle { get { return GameData.PlayerInBattle; } set { GameData.PlayerInBattle = value; } }
        public static bool GameOver { get { return GameData.GameOver; } }
        public static bool GameEnd { get { return GameData.GameEnd; } }


        /// <summary>
        /// A "setter" for the Current room, since it's a bit cumbersome to type out every time.
        /// </summary>
        /// <param name="newRoom"></param>
        public static void SetCurrentRoom(Room newRoom) { GameData.CurrentRoom = newRoom; }
        public static void SetupGameData()
        {
            MapLoader.LoadMapData(GameData.ActiveMap);
            PlayerManager.LoadPlayerData();
        }
    }
}
