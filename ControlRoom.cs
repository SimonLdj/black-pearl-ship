using BlackPearlShip.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip
{
    /// <summary>
    /// Main Control Room in the ship.
    /// Here we listen to the radio and process all the information.
    /// </summary>
    public class ControlRoom : IRadioListeners
    {
        private RadioReceiver Radio { get; set; }
        private MealAlgo MealAlgo { get; set; }
        private WeaponAlgo WeaponAlgo { get; set; }
        private DrinkingAlgo DrinkingAlgo { get; set; }

        public ControlRoom(RadioReceiver radio)
        {
            this.Radio = radio;
            this.Radio.StartListen(this);

            this.MealAlgo = new MealAlgo(this);
            this.WeaponAlgo = new WeaponAlgo(this);
            this.DrinkingAlgo = new DrinkingAlgo(this);
        }

        public void Receive(string data)
        {
            // TODO: do some logic
            throw new NotImplementedException();
        }
    }
}
