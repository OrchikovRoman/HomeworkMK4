using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.O.Decision
{
    public class DecisionCalculationDistance
    {
        public readonly List<Auto> auto = new List<Auto>();
        public int CalulationDistanceCar()
        {
            int distance = 0;
            foreach (var x in auto)
            {
                distance = x.VolumeTank * x.CountTank / x.FuelСonsumption;
            }
            return distance;
        }
    }
}
