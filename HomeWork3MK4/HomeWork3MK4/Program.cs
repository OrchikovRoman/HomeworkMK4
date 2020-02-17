using System;
using PresentatinLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork3MK4
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarsControllers carsControllers = new CarsControllers();
            IDetailControllers detailControllers = new DetailControllers();

            var result = from resC in carsControllers.GetСarsModelsView()
                         join resD in detailControllers.GetDetailViewModels()
                         on resC.Id equals resD.Cars_Id
                         select new { AutomobileName = resC.NameCar, CarID = resC.Id, Detail = resD.NameDetail };
            foreach (var obj in result)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
