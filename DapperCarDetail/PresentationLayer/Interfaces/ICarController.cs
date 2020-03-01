using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Interfaces
{
    public interface ICarController
    {
        IEnumerable<CarViewModel> GetСars();
        void Create(CarViewModel car);
        void Update(CarViewModel car);
        void Delete(int Id);
        CarViewModel GetById(int Id);
    }
}
