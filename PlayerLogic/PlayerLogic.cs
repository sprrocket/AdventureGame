using PlayerData;

namespace PlayerLogic
{
    public class PlayerManager
    {
        public PlayerEntity PlayerOne;
        public static void LoadPlayerData()
        {
            PlayerOne = new PlayerEntity
            {
                Healthpoints = 100,
                Location=[3,1]
            };
        }
    }
}
