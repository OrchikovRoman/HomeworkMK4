using System;
using System.Collections.Generic;

namespace PresentatinLayer
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetDetails();
    }
}
