using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.S
{
    public class Transport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Transport> Transports = new List<Transport>();

        public Transport(int id, string name)
        {
            Name = name;
            Id = id;
        }

        public void InsertTransport(Transport transport)
        {
            Transports.Add(transport);
            foreach (var i in Transports)
            {
                Console.WriteLine("Id: "+i.Id+", "+"Name: "+i.Name);
            }
        }
        
    }
}
