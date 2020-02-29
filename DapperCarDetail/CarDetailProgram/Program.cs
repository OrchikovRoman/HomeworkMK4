using PresentationLayer.Controllers;
using PresentationLayer.Interfaces;
using PresentationLayer.Models;
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
            ICarController carController = new CarController();
            IDetailController detailController = new DetailController();

            var lamborgini = new CarViewModel() { Name="Lamborgini" };
            var engine = new DetailViewModel() { CarID=9, Name="Engine"};
            detailController.Create(engine);
            carController.Create(lamborgini);

            foreach (var res in carController.GetСars())
            {
                Console.WriteLine($"Name:{res.Name}, Id:{res.Id}");
                foreach (var item in res.Details)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.CarID}");
                }
            }

            

            Console.ReadKey();
        }
    }
}
