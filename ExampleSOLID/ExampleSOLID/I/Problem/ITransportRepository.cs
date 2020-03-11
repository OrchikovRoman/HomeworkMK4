using ExampleSOLID.L.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.I.Problem
{
    public interface ITransportRepository
    {
        void AddCar(Car car);
        void AddMotocycle(Motorcycle motorcycle);
        void AddTransport(Transport transport);
    }
}
