using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackPearlShip
{
    public interface IRadioListeners
    {
        /// <summary>
        /// Receive data form radio
        /// </summary>
        void Receive(string data);
    }
}
