using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        // TODO  
        // ID veritabanında kendiliğinden eklenecek!!!
        CarManager carManager = new CarManager(new EfCarDal());
        Car car1 = new Car{Id = 38, BrandId = 1, ColorId = 5, DailyPrice = 100, ModelYear = 2014, Description = "Toyota Auris"};
        carManager.AddCar(car1);
        
        foreach (var car in carManager.GetCarsByBrandId(1))
        {
            Console.WriteLine($"{car.Description}");
        }
    }
}