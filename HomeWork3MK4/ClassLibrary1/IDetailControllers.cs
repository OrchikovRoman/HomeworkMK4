using System;
using System.Collections.Generic;

namespace PresentatinLayer
{
    public interface IDetailControllers
    {
        IEnumerable<DetailViewModel> GetDetailViewModels();
    }
}
