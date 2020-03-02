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

            //var lamborgini = new CarViewModel() {Id=5, Name="Lamborgini" };
            //var seat = new DetailViewModel() {Id=5, CarID = 4, Name = "Seat" };
            //detailController.Create(seat);
            //carController.Create(lamborgini);

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
