using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer
{
    public interface ICarsServices
    {
        IEnumerable<CarModel> GetСarsModels();
    }
}
