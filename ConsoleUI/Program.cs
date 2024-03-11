using Business.Concrete;
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
        //ColorTest();

        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        Rental rental3 = new Rental { CarId = 5, CustomerId = 4, RentDate = DateTime.Now};
        rentalManager.Insert(rental3);

        foreach (var Rental in rentalManager.GetAll().Data)
        {
            Console.WriteLine($"{Rental.Id} {Rental.CarId} {Rental.CustomerId} {Rental.RentDate} {Rental.ReturnDate?.ToString()}");
        }
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