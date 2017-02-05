using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip
{
    public class Crew
    {
        private Radio radio;

        public Crew(Radio radio)
        {
            this.radio = radio;
        }

        internal void Sail()
        {
            // The crew Broadcast some data using the radio
            radio.BroadcastMessage("Hello Black Pearl!");

            // day 1
            Console.WriteLine("======= day #1 ======");
            radio.BroadcastDaysAtSea(1);
            runTime(radio, 0, 7);
            radio.BroadcastCrewHunger(6);
            radio.BroadcastTime(7);
            runTime(radio, 8, 14);
            radio.BroadcastEnemyDetected(Direction.South);
            runTime(radio, 14, 24);

            // day 2
            Console.WriteLine("======= day #2 ======");
            radio.BroadcastDaysAtSea(2);
            runTime(radio, 0, 7);
            radio.BroadcastCrewHunger(4);
            radio.BroadcastTime(7);
            runTime(radio, 8, 10);
            radio.BroadcastEnemyDetected(Direction.West);
            runTime(radio, 10, 18);
            radio.BroadcastEnemyDetected(Direction.West);
            radio.BroadcastTime(18);
            radio.BroadcastCrewHunger(10);
            radio.BroadcastTime(19);
            runTime(radio, 20, 24);

            // day 3
            Console.WriteLine("======= day #3 ======");
            radio.BroadcastDaysAtSea(3);
            runTime(radio, 0, 3);
            radio.BroadcastEnemyDetected(Direction.North);
            radio.BroadcastTime(3);
            radio.BroadcastEnemyDetected(Direction.West);
            runTime(radio, 4, 24);
        }

        /// <summary>
        /// Help method to pass time from start to end (not including end)
        /// </summary>
        private static void runTime(Radio radio, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                radio.BroadcastTime(i);
            }
        }
    }
}
