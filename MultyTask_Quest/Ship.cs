using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyTask_Quest
{
    internal class Ship
    {
        public int Fullfeelment { get; set; } = 0;
        public int Capasity { get; set; }

        public Ship(int capasity)
        {
            this.Capasity = capasity;
        }

        public void add(int fullfeelment)
        {
            this.Fullfeelment++;
        }

        public bool countCheck()
        {
            if (Capasity >= this.Fullfeelment)
            {
                return false;
            }
            return true;
        }

    }
}


