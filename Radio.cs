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
    public class Radio
    {
        public List<IRadioListeners> Listeners { get; set; }

        public Radio()
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

        public void BroadcastMessage(string message)
        {
            foreach (var listener in Listeners)
            {
                listener.ReceiveMessage(message);
            }
        }

        public void BroadcastTime(int time)
        {
            foreach (var listener in Listeners)
            {
                listener.ReceiveTime(time);
            }
        }

        public void BroadcastCrewHunger(int hunger)
        {
            foreach (var listener in Listeners)
            {
                listener.ReceiveCrewHunger(hunger);
            }
        }

        public void BroadcastEnemyDetected(Direction direction)
        {
            foreach (var listener in Listeners)
            {
                listener.ReceiveEnemyDirection(direction);
            }
        }
    }
}
