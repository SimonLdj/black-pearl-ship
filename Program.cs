using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create radio and give it to the captain
            var radio = new Radio();
            var captain = new Captain(radio);

            // TODO: put this code in some "Crew" class

            // The crew Broadcast some data using the radio
            radio.BroadcastMessage("Hello Black Pearl!");

            // day 1
            // TODO: broadcast day number
            runTime(radio, 0, 7);
            radio.BroadcastCrewHunger(6);
            radio.BroadcastTime(7);
            runTime(radio, 8, 14);
            radio.BroadcastEnemyDetected(Direction.South);
            runTime(radio, 14, 22);
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
