using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignments
{
    public class Car : IVehicle, IDrivable
    {
        private int gasoline;

        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }

        // IVehicle implementation
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("No gasoline left to drive.");
            }
        }

        public bool Refuel(int amount)
        {
            gasoline += amount;
            return true;
        }

        // IDrivable implementation
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }

        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating.");
        }
    }

}
