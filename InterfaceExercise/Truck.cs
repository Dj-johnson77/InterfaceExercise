using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck() { }
        
        public bool CanHaul { get; set; } = true;

        public string BedSize { get; set; } = "Large";

        public int NumOfWheels { get; set; } = 4;
        public bool UseGas { get; set; } = true;
        public bool ItRuns { get; set; } = true;
        public bool IsSafe { get; set; } = true;
        public string CompanyName { get; set; } = "Ford";
        public bool IsReputable { get; set; } = true;
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
           if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} is now driving forward.");
            }
           else
            {
                Console.WriteLine($"The {GetType().Name} is now driving forward.");
            }
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
