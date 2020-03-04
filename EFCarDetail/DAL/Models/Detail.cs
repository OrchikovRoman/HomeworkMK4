using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Detail")]
    public class Detail
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Car Car { get; set; }

        public int DetailTypeId { get; set; }
        public virtual DetailType DetailType { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
