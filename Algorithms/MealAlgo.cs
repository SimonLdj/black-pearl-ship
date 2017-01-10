using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip.Algorithms
{
    /// <summary>
    /// Algorithm to determine what to eat and how much.
    /// Input:   time
    ///          crew hunger
    /// Output:  type of food to eat
    ///          amount of food to eat
    /// </summary>
    public class MealAlgo
    {
        private ControlRoom ControlRoom { get; set; }
        private int lastCrewHunger;
        private Random random;

        public MealAlgo(ControlRoom cr)
        {
            this.ControlRoom = cr;
            lastCrewHunger = 1;
            random = new Random();
        }

        // Input

        /// <summary>
        /// Get current time, from 0 to 23
        /// </summary>
        public void InputTime(int hour)
        {
            var hunger = CalculateHunger(hour, lastCrewHunger);

            if (hunger > 5)
            {
                OutputAmountOfFoodToEat(hunger);
                OutputTypeOfFoodToEat(getTypeOfFoodByTime(hour));
            }
        }

        /// <summary>
        /// Get crew hunger, from 0 to 10;
        /// </summary>
        public void InputCrewHunger(int hunger)
        {
            lastCrewHunger = hunger;
        }

        // Output

        /// <summary>
        /// Send type of food to eat to ControlRoom
        /// </summary>
        private void OutputTypeOfFoodToEat(FoodType type)
        {
            ControlRoom.SetTypeOfFoodToEat(type);
        }

        /// <summary>
        /// Send amount of food to eat to ControlRoom
        /// </summary>
        private void OutputAmountOfFoodToEat(int amount)
        {
            ControlRoom.SetAmountOfFoodToEat(amount);
        }

        // Algorithm

        /// <summary>
        /// Calculate hunger according to given time and crew hunger
        /// </summary>
        private int CalculateHunger(int time, int crewHunger)
        {
            var timeToHunger = new Dictionary<int, int>(){
                { 0 , 1},
                { 1 , 1},
                { 2 , 1},
                { 3 , 1},
                { 4 , 1},
                { 5 , 3},
                { 6 , 5},
                { 7 , 7}, // breakfast time
                { 8 , 1},
                { 9 , 1},
                { 10, 1},
                { 11, 4},
                { 12, 8},
                { 13, 10}, // Lunch Harrr!!
                { 14, 1},
                { 15, 1},
                { 16, 2},
                { 17, 2},
                { 18, 2},
                { 19, 4},
                { 20, 6}, // Supper
                { 21, 7},
                { 22, 1},
                { 23, 1},
            };

            var timeHunger = timeToHunger[time];

            return (int)(timeHunger * 0.5 + crewHunger * timeHunger * 0.5);
        }

        private FoodType getTypeOfFoodByTime(int time)
        {
            var r = this.random.Next(2);

            // breakfast
            if (time >= 5 && time < 11)
                return r == 1 ? FoodType.SeaBiscuits : FoodType.Bread;
            // Lunch
            if (time >= 11 && time < 17)
                return r == 1 ? FoodType.SaltedMeat : FoodType.Slop;
            // Supper
            if (time >= 17 && time < 21)
                return r == 1 ? FoodType.Fruit : FoodType.Veggies;

            // other (night)
            return FoodType.SeaBiscuits;
        }
    }

    public enum FoodType { SeaBiscuits, SaltedMeat, Slop, Fruit, Bread, Veggies}
}
