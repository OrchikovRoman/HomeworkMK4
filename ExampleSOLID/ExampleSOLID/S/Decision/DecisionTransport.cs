using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.S
{
    public class DecisionTransport
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DecisionTransport(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
