using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyTask_Quest
{
    internal class ShipGenerator
    {


        Thread myThread = new Thread(ShipGenerator());

        public ShipGenerator(Tunnel tunnel) {
            
            int count = 0;
            while (count < tunnel.ShipCounter)
            {
                Thread.currentThread().setName(" Generator ship");
                count++;
                tunnel.addShipInTunnel(new Ship(GetRundomCapacity()));
                try
                {
                    Thread.sleep(1000);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine("ShipGeneratorError");
                }
            }
        

    }

        public int GetRundomCapacity()
        {
            int value;
            Random rand = new Random();
            return value = rand.Next(0, 5);
        }

    }
}
