using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV() { }
        
        public bool HasHitch { get; set; } = true;
        public string CargoSize { get; set; } = "medium";

        public int NumOfWheels { get; set; } = 4;
        public bool UseGas { get; set; } = true;
        public bool ItRuns { get; set; } = true;
        public bool IsSafe { get; set; } = true;
        public string CompanyName { get; set; } = "Ford";
        public bool IsReputable { get; set; } = true;
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is now driving forward.");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now reversing.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now parked.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }

        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }
}
