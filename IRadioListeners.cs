using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackPearlShip
{
    public interface IRadioListeners
    {
        /// <summary>
        /// Receive message from the radio
        /// </summary>
        void ReceiveMessage(string message);

        /// <summary>
        /// Receive time data (0-23) from the radio
        /// </summary>
        void ReceiveTime(int time);

        /// <summary>
        /// Receive crew hunger (1-10)
        /// </summary>
        void ReceiveCrewHunger(int hunger);

        /// <summary>
        /// Receive enemies detected direction
        /// </summary>
        void ReceiveEnemyDirection(Direction direction);

        /// <summary>
        /// Receive days at sea
        /// </summary>
        void ReceiveDaysAtSea(int day);
    }

    public enum Direction { North, West, East, South}
}
