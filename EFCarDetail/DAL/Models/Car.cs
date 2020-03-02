using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Car")]
    public class Car
    {
        public Car()
        {
            Details = new List<Detail>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Detail Detail { get; set; }
        public ICollection<Detail> Details { get; set; }

    }
}
