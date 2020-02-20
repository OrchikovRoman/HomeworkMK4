using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetСars();
    }
}
