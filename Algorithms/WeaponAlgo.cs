using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip.Algorithms
{
    /// <summary>
    /// Algorithm that controls all fire weapons in the ship.
    /// Input:   enemies detected
    ///          enemies direction
    ///          amount crew drank (From DrinkAlgo)
    ///          amount crew ate (from MealAlgo)
    /// Output:  cannon number to fire
    ///          did we hit or miss the target
    /// </summary>
    public class WeaponAlgo
    {
        private ControlRoom ControlRoom { get; set; }

        public WeaponAlgo(ControlRoom cr)
        {
            this.ControlRoom = cr;
        }
    }
}
