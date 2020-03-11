using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.L.Problem
{
    public class Motorcycle : Transport
    {
        public int CountWheel { get; set; }
        public int PassengerCapacity { get; set; }

        public Motorcycle(string Name, int CountWheel, int PassengerCapacity) :base (Name)
        {
            CountWheel = this.CountWheel;
            PassengerCapacity = this.PassengerCapacity;
        }
    }
}
