using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new InMemoryCarDal());
            
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "   " + car.ColorId + "   " + car.BrandId + "   " + car.DailyPrice + "   " + car.Description + "   " + car.ModelYear);
                
            }
        }
    }
}
