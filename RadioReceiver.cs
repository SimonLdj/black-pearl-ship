using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip
{
    /// <summary>
    /// This is the main radio receiver of the Ship.
    /// All ships information about the world come form here
    /// </summary>
    public class RadioReceiver
    {
        public List<IRadioListeners> Listeners { get; set; }

        public RadioReceiver()
        {
            Listeners = new List<IRadioListeners>();
        }

        /// <summary>
        /// Add listener to the radio
        /// </summary>
        public void StartListen(IRadioListeners listener)
        {
            Listeners.Add(listener);
        }

        /// <summary>
        /// Broadcast data to listeners
        /// </summary>
        public void Broadcast(string data)
        {
            foreach (var listener in Listeners)
            {
                listener.Receive(data);
            }
        }
    }
}
