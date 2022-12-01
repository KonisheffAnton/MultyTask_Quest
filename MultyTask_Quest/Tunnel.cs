using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyTask_Quest
{
    internal class Tunnel
    {
        private List<Ship> store;
        const int MaxShipIntTunnel = 5;
        const int MinShipInTunnel = 0;
        public int ShipCounter { get; set; } = 0;
        public void addShipInTunnel(Ship ship)
        {
            this.store.Add(ship);
            this.ShipCounter++;
        }
        public Ship getShipFromTunnel(List<Ship> store)
        {
            if (ShipCounter > MinShipInTunnel)
            {
                foreach (Ship ship in store)
                {
                    ShipCounter--;
                    // System.out.println(store.size() + "- The ship is taken from the tunnel: " + Thread.currentThread().getName());
                    store.RemoveAt(0);
                    return ship;
                }

            }
            return null;
        }


    }
}
