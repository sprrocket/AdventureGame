using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData
{
    [Serializable]
    public class PlayerEntity
    {
        public int CurrentRow { get; set; }
        public int CurrentCol { get; set; }
        public double Healthpoints { get; set; }
        public int Strength { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
    }
}
