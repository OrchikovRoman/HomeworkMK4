using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.O.Problem
{
    public class CalculationDistance
    {
        public readonly List<Car> car = new List<Car>();
        public int CalulationDistanceCar()
        {
            int distance = 0;
            foreach (var i in car)
            {
                if (i.Classification == 1)
                {
                    distance = i.VolumeTank / i.FuelСonsumption;
                    return distance;
                }
                else if (i.Classification == 2)
                {
                    distance = (i.VolumeTank * 2) / i.FuelСonsumption;
                    return distance;
                }
            }
            return distance;
        }
    }
}
