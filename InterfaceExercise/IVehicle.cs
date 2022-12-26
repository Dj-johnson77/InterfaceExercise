using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public bool UseGas { get; set; }

        public bool ItRuns { get; set; }
        public bool IsSafe { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();

        public void Reverse();

        public void Park();
        public void ChangeGears(bool isChanged);
    }
}
