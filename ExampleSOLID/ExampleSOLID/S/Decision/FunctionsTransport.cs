using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.S.Decision
{
    public class FunctionsTransport
    {
        public List<DecisionTransport> decTransports = new List<DecisionTransport>();
        public void ViewTransport()
        {
            foreach (var i in decTransports)
            {
                Console.WriteLine($"Id: {i.Id}, Name: {i.Name}");
            }
        }
        public void InsertTransport(DecisionTransport transport)
        {
            decTransports.Add(transport);
        }
       
    }
}
