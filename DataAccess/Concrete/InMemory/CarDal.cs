using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory;

public class CarDal : ICarDal
{
    private List<Car> _cars;

    public CarDal()
    {
        _cars = new List<Car>
        {
            new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 40, ModelYear = 2016, Description = "Stoktaki 1. araç" },
            new Car{Id = 2, BrandId = 1, ColorId = 5, DailyPrice = 22, ModelYear = 2005, Description = "Stoktaki 2. araç" },
            new Car{Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 65, ModelYear = 2019, Description = "Stoktaki 3. araç" },
            new Car{Id = 4, BrandId = 2, ColorId = 7, DailyPrice = 15, ModelYear = 2001, Description = "Stoktaki 4. araç" },
            new Car{Id = 5, BrandId = 2, ColorId = 6, DailyPrice = 35, ModelYear = 2022, Description = "Stoktaki 5. araç" },
        };
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car GetById(int Id)
    {
        Car carToGetById = _cars.SingleOrDefault(c => c.Id == Id);
        return carToGetById;
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.Find(c => c.Id == car.Id);
        carToUpdate.Description = car.Description;
        carToUpdate.DailyPrice = car.DailyPrice;
    }

    public void Delete(Car car)
    {
        Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        _cars.Remove(carToDelete);
    }

    public List<CarDetailDto> GetCarDetails()
    {
        throw new NotImplementedException();
    }
}