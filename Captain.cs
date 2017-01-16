using BlackPearlShip.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip
{
    /// <summary>
    /// controls the ship and tells the crew what to do.
    /// Here we listen to the radio and process all the information.
    /// </summary>
    public class Captain : IRadioListeners
    {
        private Radio Radio { get; set; }
        private Galley Galley { get; set; }
        private GunDeck GunDeck { get; set; }
        private RumHall RumHall { get; set; }

        public Captain(Radio radio)
        {
            this.Radio = radio;
            this.Radio.StartListen(this);

            this.Galley = new Galley(this);
            this.GunDeck = new GunDeck(this);
            this.RumHall = new RumHall(this);
        }

        #region Input from Radio

        // TODO: add input days-at-sea

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Radio: " + message);
        }

        public void ReceiveTime(int time)
        {
            Galley.InputTime(time);
            GunDeck.InputTime(time);
            RumHall.InputTime(time);
        }

        public void ReceiveCrewHunger(int hunger)
        {
            Galley.InputCrewHunger(hunger);
        }

        public void ReceiveEnemyDirection(Direction direction)
        {
            GunDeck.InputEnemiesDirection(direction);
        }

        #endregion Input from Radio

        #region input from Departments

        /// <summary>
        /// Receive from RumHall how much the crew should drink
        /// </summary>
        public void SetAmountToDrink(int amount)
        {
            // TODO: let the crew drink

            // let other departments know about it
            GunDeck.InputAmountCrewDrank(amount);
        }

        /// <summary>
        /// Receive from Galley type of food crew should eat
        /// </summary>
        public void SetTypeOfFoodToEat(FoodType foodType)
        {
            GunDeck.InputCrewAteType(foodType);
            RumHall.InputFoodAte(foodType);
        }

        /// <summary>
        /// Receive from Galley amount of food crew should eat
        /// </summary>
        public void SetAmountOfFoodToEat(int amount)
        {

        }

        /// <summary>
        /// Receive from GunDeck canon number to fire
        /// </summary>
        public void SetCanonToFire(int canonNumber)
        {

        }

        /// <summary>
        /// Receive from GunDeck did we hit or miss the enemy ship
        /// </summary>
        public void SetHitOrMissEnemyShip(bool isHit)
        {
            RumHall.InputHitOrMiss(isHit);
        }

        #endregion input from Departments
    }
}
