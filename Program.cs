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
            // create radio and give it to the control room
            var radio = new RadioReceiver();
            var controlRoom = new ControlRoom(radio);

            // Broadcast some data through the radio
            radio.Broadcast("Hello Black Pearl!");
            radio.Broadcast("How are you today?");

        }
    }
}
