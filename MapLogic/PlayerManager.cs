using MapData;
using PlayerData;

namespace MapLogic
{
    public class PlayerManager
    {
        private static System.Random rng = new System.Random();
        public static PlayerEntity PlayerOne = new PlayerEntity();
        public static PlayerEntity NPC = new PlayerEntity();

        public static void SetPlayerLocation(int row, int col)
        {
            PlayerOne.CurrentCol = col;
            PlayerOne.CurrentRow = row;
        }

        public static void LoadPlayerData()
        {
            PlayerOne.Healthpoints = 100;
            PlayerOne.CurrentRow = GameData.CurrentRoom.Row;
            PlayerOne.CurrentCol = GameData.CurrentRoom.Column;

            NPC.Healthpoints = 100;
        }

        public static string BattleStartMessage()
        {
            return "An NPC has appeared!\n\n" + BattleMessage();
        }

        public static string BattleMessage()
        {
            return "Player Health: " + PlayerOne.Healthpoints + "\tNPC Health: " + NPC.Healthpoints;
        }

        public static void StartBattle()
        {
            GameData.PlayerInBattle = true;
        }

        public static void BattleTurn()
        {
            PlayerOne.Healthpoints = PlayerOne.Healthpoints - rng.Next(0, 10);
            NPC.Healthpoints = NPC.Healthpoints-rng.Next(0, 10);
            if (PlayerOne.Healthpoints <= 0) { GameData.PlayerInBattle = false; GameData.GameOver = true; MapManager.CurrentRoomDescription = "Game Over! Try again!"; }
            else if (NPC.Healthpoints <= 0) { GameData.PlayerInBattle = false; GameData.GameEnd = true; MapManager.CurrentRoomDescription = "You Win! Thanks for playing!"; }
            else { MapManager.CurrentRoomDescription = BattleMessage(); }
        }
    }
}
