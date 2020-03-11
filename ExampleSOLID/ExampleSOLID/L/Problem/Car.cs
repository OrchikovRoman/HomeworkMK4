using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.L.Problem
{
    public class Car : Motorcycle
    {
        public int TrunkVolume { get; set; }
        public Car(string Name, int CountWheel, int PassengerCapacity, int TrunkVolume) : base(Name, CountWheel, PassengerCapacity)
        {
            TrunkVolume = this.TrunkVolume;
        }
        public int CountWheels
        {
            set
            {
                CountWheels = CountWheel * 2;
            }
            get { return CountWheels; }
        }
        public int PassengersCapacity
        {
            set
            {
                PassengersCapacity = PassengerCapacity * 3;
            }
            get { return PassengersCapacity; }
        }
    }
}
