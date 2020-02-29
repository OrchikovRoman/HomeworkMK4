using BuisnessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetСars();
        void Create(CarModel car);
        void Delete(CarModel car);
        void Update(CarModel car);
        CarModel GetById(int Id);
    }
}
