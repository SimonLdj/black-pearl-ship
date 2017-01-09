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

        public ControlRoom(RadioReceiver radio)
        {
            this.Radio = radio;
            this.Radio.StartListen(this);
        }

        public void Receive(string data)
        {
            // TODO: do some logic
            throw new NotImplementedException();
        }
    }
}
