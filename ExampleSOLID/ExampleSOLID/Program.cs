using ExampleSOLID.S;
using ExampleSOLID.S.Decision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //S:Single Responsibility Principle 

            //Problem
            var car = new Transport(1, "Audi");
            car.InsertTransport(car);
            //Decision
            var carDecision = new DecisionTransport(1, "Audi");
            var result = new FunctionsTransport();
            result.InsertTransport(carDecision);
            result.ViewTransport();
            //O:Open-Closed Principle 


            Console.ReadKey();
        }
    }
}
