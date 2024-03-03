using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        
        CarManager carManager = new CarManager(new EfCarDal());
        Car car1 = new Car{BrandId = 1, ColorId = 5, DailyPrice = 100, ModelYear = 2014, Description = "Toyota Auris"};
        carManager.AddCar(car1);
        
        foreach (var car in carManager.GetCarsByBrandId(1))
        {
            Console.WriteLine($"{car.Description}");
        }
    }
}