using ExampleSOLID.L.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.I.Problem
{
    public interface IDecTransportRepository
    {
        void AddTransport(Transport transport);
    }
}
