using System;
using System.Collections.Generic;
using System.Text;

namespace PresentatinLayer
{
    public interface ICarsControllers
    {
        IEnumerable<CarViewModel> GetCarsModelsView();
    }
}
