using System;

namespace PresentatinLayer
{
    public interface IDetailControllers
    {
        IEnumerable<DetailViewModel> GetDetailViewModels();
    }
}
