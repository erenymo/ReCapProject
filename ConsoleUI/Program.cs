﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI;

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

        foreach (var color in colorManager.GetAll().Data)
        {
            Console.WriteLine($"{color.Name}");
        }
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        
        foreach (var brand in brandManager.GetAll().Data)
        {
            Console.WriteLine($"{brand.Name}");
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        
        foreach (var car in carManager.GetCarDetails().Data)
        {
            Console.WriteLine($"{car.Name} {car.BrandName} {car.ColorName} {car.DailyPrice}");
        }
    }
}