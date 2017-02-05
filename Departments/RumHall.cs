using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip.Departments
{
    /// <summary>
    /// Determine how much Rum the crew should drink.
    /// Input:  time
    ///         Number of days at sea
    ///         did we hit or miss enemies ship (from GunDeck)
    ///         type of food crew ate (from Galley Department)
    /// Output: amount of rum to drink
    /// </summary>
    public class RumHall
    {
        private Captain Captain { get; set; }
        private int currentTime;
        private FoodType lastFood;

        public RumHall(Captain cr)
        {
            this.Captain = cr;
            currentTime = 0;
            lastFood = FoodType.Bread;
        }

        // Input

        /// <summary>
        /// Get current time, from 0 to 23
        /// </summary>
        public void InputTime(int hour)
        {
            currentTime = hour;
            var amount = CalculateProbabilityToDrink(currentTime, lastFood);
            OutputAmountToDrink(amount);
        }

        public void InputHitOrMiss(bool isHit)
        {
            // We hit a ship?! That's great reason to drink Harrrr!
            if (isHit)
            {
                OutputAmountToDrink(100);
            }
            // Miss? that's bad, lets drink...
            else
            {
                OutputAmountToDrink(10);
            }
        }

        public void InputFoodAte(FoodType foodType)
        {
            lastFood = foodType;
        }

        public void InputDaysAtSea(int days)
        {
            // Assume doing something with this input
        }

        // Output

        /// <summary>
        /// Send amount to drink to Captain
        /// </summary>
        private void OutputAmountToDrink(int amount)
        {
            Captain.SetAmountToDrink(amount);
        }

        // Algorithms

        private int CalculateProbabilityToDrink(int time, FoodType lastFood)
        {
            // the effect of time
            var timeProb = 0;

            // midnight to morning is a good time to drink
            if (time > 0 && time < 7)
                timeProb += 5;
            // Thats a good time to drink...
            if (time == 14)
                timeProb += 10;
            // Its been hour since we drank...
            if (time % 2 == 0)
                timeProb += 1;

            // the effect of food
            var foodProb = 0;
            if (lastFood == FoodType.SaltedMeat && lastFood == FoodType.Slop)
                foodProb += 5;
            if (lastFood == FoodType.SeaBiscuits && lastFood == FoodType.Bread)
                foodProb += 2;

            return (int)(timeProb * 0.5 + foodProb * 0.5);
        }
    }
}
