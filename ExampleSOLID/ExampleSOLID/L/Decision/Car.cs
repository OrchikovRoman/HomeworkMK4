using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.L.Problem
{
    public class decCar : decTransport
    {
        public int TrunkVolume { get; set; }
        public int CountWheel { get; set; }
        public int PassengerCapacity { get; set; }
        public decCar(string Name, int CountWheel, int PassengerCapacity, int TrunkVolume) : base(Name)
        {
            TrunkVolume = this.TrunkVolume;
            CountWheel = this.CountWheel;
            PassengerCapacity = this.PassengerCapacity;
        }
        
    }
}
