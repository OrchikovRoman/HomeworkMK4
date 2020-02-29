using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Interfaces
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetDetails();
        void Create(DetailViewModel detail);
        void Delete(DetailViewModel detail);
        void Update(DetailViewModel detail);
        DetailViewModel GetById(int Id);
    }
}
