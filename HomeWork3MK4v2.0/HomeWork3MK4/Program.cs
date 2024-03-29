﻿using System;
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
            ICarController carsControllers = new CarController();
            IDetailController detailControllers = new DetailController();

            var result = from resC in carsControllers.GetСars()
                         join resD in detailControllers.GetDetails()
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
