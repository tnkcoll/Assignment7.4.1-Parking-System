using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._4._1_Parking_System
{
    internal class ParkingSystem
    {
        private int Big { get; set; }
        private int Medium { get; set; }
        private int Small { get; set; }

        public ParkingSystem(int big, int medium, int small)
        {
            Big = big;
            Medium = medium;
            Small = small;
        }

        public bool addCar(int carType)
        {
            return ParkingSlotsAvailabe(carType);
        }

        public void removeCar(int carType)
        {
            try
            {
                switch (carType)
                {
                    case 1:
                        if (Big <= 3)
                        {
                            Big++;
                        }
                        break;
                    case 2:
                        if (Medium <= 3)
                        {
                            Medium++;
                        }
                        break;
                    case 3:
                        if (Small <= 3)
                        {
                            Small++;
                        }
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fix the car type and run the program again.");
            }
        }

        private bool ParkingSlotsAvailabe(int size)
        {
            switch (size)
            {
                case 1:
                    if (Big > 0)
                    {
                        Big--;
                        return true;
                    }

                    break;
                case 2:
                    if (Medium > 0)
                    {
                        Medium--;
                        return true;
                    }
                    break;
                case 3:
                    if (Small > 0)
                    {
                        Small--;
                        return true;
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }

    }
}
