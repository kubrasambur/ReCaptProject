using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car,Brand brand)
        {
            if(car.DailyPrice>0 && brand.BrandName.Length>2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlük tutarını vaya araba ismini yanlış girdiniz");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id).ToList();
            
        }


        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId==Id).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
