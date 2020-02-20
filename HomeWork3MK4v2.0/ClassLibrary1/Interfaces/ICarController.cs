using System;
using System.Collections.Generic;
using System.Text;

namespace PresentatinLayer
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetСars();
    }
}
