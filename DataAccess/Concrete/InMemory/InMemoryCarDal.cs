using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId=1 , DailyPrice = 200, ModelYear="2016", Description="4+1"},
                new Car{Id = 2, BrandId = 2, ColorId=1 , DailyPrice = 150, ModelYear="2015", Description="4+1"},
                new Car{Id = 3, BrandId = 3, ColorId=3 , DailyPrice = 500, ModelYear="2019", Description="1+1"},
                new Car{Id = 4, BrandId = 4, ColorId=2 , DailyPrice = 200, ModelYear="2016", Description="4+1"},
                new Car{Id = 5, BrandId = 1, ColorId=2 , DailyPrice = 150, ModelYear="2015", Description="3+1"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = null;
            deleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);   //Id si eşleşen Liste elemanının referansını alır
            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Cars Tablosu");
            return _cars;
        }

        public List<Car> GetById(int Id)     //ürünleri Id ye göre getir
        {
            Console.WriteLine("ID ye Göre Fitreleme");
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = null;
            updateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}
