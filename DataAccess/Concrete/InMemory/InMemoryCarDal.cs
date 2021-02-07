using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=500, ModelYear=2003, Description="Depo Doludur"},
                new Car {Id=2, BrandId=2, ColorId=3, DailyPrice=800, ModelYear=2014, Description="Depo yarımdır"},
                new Car {Id=3, BrandId=3, ColorId=6, DailyPrice=400, ModelYear=2009, Description="Depo boştur"},
                new Car {Id=4, BrandId=4, ColorId=8, DailyPrice=700, ModelYear=2004, Description="Depo boştur"},
                new Car {Id=5, BrandId=5, ColorId=9, DailyPrice=200, ModelYear=2019, Description="Depo yarımdır"}

                };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);

            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int CarId)
        {
            return _car.Where(c => c.Id == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
