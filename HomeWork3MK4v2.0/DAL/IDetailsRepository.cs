using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IDetailsRepository
    {
        IEnumerable<Detail> GetDetails();
    }
}
