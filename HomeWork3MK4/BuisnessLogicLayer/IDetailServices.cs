using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer
{
    public interface IDetailServices
    {
        IEnumerable<DetailModel> GetDetailModels();
    }
}
