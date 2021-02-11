using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //BrandTest();

            ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAllColors();
            if(result.Success==true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAllBrands();
            if(result.Success==true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car() {ColorId=3, ModelYear=2015, DailyPrice=700, BrandId=3, Descriptions="Manuel dizel"});
            var result = carManager.GetCarsByColorId(3);
            if(result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ColorId);
                }
            }else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
