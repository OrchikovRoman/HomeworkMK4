using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        void Create(Car car);
        void Update(Car car);
        void Delete(int Id);
        Car GetById(int id);
        Car GetByName(string Name);
        
    }
}
