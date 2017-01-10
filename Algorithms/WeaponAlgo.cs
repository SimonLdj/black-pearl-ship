using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackPearlShip.Algorithms
{
    /// <summary>
    /// Algorithm that controls all fire weapons in the ship.
    /// Input:   time
    ///          enemies direction
    ///          amount crew drank (From DrinkAlgo)
    ///          type of food crew ate (from MealAlgo)
    /// Output:  cannon number to fire
    ///          did we hit or miss the target
    /// </summary>
    public class WeaponAlgo
    {
        private ControlRoom ControlRoom { get; set; }
        private FoodType lastFoodCrewAte;
        // how much rum accumulated in the crew stomach
        private int rumAccumilation;

        public WeaponAlgo(ControlRoom cr)
        {
            this.ControlRoom = cr;
            lastFoodCrewAte = FoodType.SeaBiscuits;
            rumAccumilation = 0;
        }

        // Input

        public void InputEnemiesDirection(Direction direction)
        {
            var rumEffect = CalculateRumEffect(rumAccumilation, lastFoodCrewAte);
            var isHit = CalculateCanHit(rumEffect, direction);
            OutputHitOrMiss(isHit);
        }

        public void InputAmountCrewDrank(int amount)
        {
            rumAccumilation += amount;
        }

        public void InputCrewAteType(FoodType type)
        {
            lastFoodCrewAte = type;
        }

        /// <summary>
        /// Get current time, from 0 to 23
        /// </summary>
        public void InputTime(int hour)
        {
            rumAccumilation -= 2;
            if (rumAccumilation < 0) rumAccumilation = 0;
        }

        // Output

        private void OutputCannonNumberToFire(int cannonNumber)
        {
            ControlRoom.SetCanonToFire(cannonNumber);
        }
        private void OutputHitOrMiss(bool isHit)
        {
            ControlRoom.SetHitOrMissEnemyShip(isHit);
        }

        // Algorithm

        private double CalculateRumEffect(int amountDrank, FoodType foodAte)
        {
            switch (foodAte)
            {
                case FoodType.SaltedMeat:
                case FoodType.Slop:
                    return amountDrank * 0.1;
                case FoodType.SeaBiscuits:
                case FoodType.Bread:
                    return amountDrank * 0.5;
                case FoodType.Fruit:
                case FoodType.Veggies:
                default:
                    return amountDrank * 1.0;
            }
        }

        private bool CalculateCanHit(double rumEffect, Direction enemyDirection)
        {
            bool rumEffecting = rumEffect > 10;
            double directionEffect = 0;

            // If crew drank, it's harder to aim sought and east
            if (rumEffecting &&
                (enemyDirection ==  Direction.South || enemyDirection == Direction.East))
            {
                directionEffect = 1;
            }

            var totalProbability = 100 - rumEffect - 10*directionEffect;

            return totalProbability > 50 ? true : false;
        }
    }

    public enum Direction { North, West, East, South}
}
