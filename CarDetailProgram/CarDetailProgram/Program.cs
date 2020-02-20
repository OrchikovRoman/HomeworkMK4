using PresentationLayer.Controllers;
using PresentationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarDetailProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarController carsControllers = new CarController();
            IDetailController detailControllers = new DetailController();

            var result = from resC in carsControllers.GetСars()
                         join resD in detailControllers.GetDetails()
                         on resC.Id equals resD.CarID
                         select new { AutomobileName = resC.Name, CarID = resC.Id, Detail = resD.Name };
            foreach (var obj in result)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
