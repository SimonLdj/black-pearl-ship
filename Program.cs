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
            // create radio and give it to the captain and the crew
            var radio = new Radio();
            var captain = new Captain(radio);
            var crew = new Crew(radio);

            // Let's Sail Arrr!
            crew.Sail();

            // avoid closing console when debugging
            Console.ReadKey();
        }
    }
}
