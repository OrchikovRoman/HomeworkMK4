using System;
using System.Collections.Generic;

using System.Text;

namespace DAL
{
    public interface ICarsRepository
    {
        IEnumerable<Car> GetCars();
    }
}
