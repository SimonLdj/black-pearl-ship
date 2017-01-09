using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip.Algorithms
{
    /// <summary>
    /// Algorithm to determine when to eat and how much.
    /// Input:   time
    ///          crew hunger
    /// Output:  type of food to ear
    ///          amount of food to eat
    /// </summary>
    public class MealAlgo
    {
        private ControlRoom ControlRoom { get; set; }

        public MealAlgo(ControlRoom cr)
        {
            this.ControlRoom = cr;
        }
    }
}
