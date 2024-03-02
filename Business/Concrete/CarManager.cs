using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public List<Car> GetCarsByBrandId(int Id)
    {
        return _carDal.GetAll(p => p.BrandId == Id);
    }

    public List<Car> GetCarsByColorId(int Id)
    {
        return _carDal.GetAll(p => p.ColorId == Id);
    }

    public void AddCar(Car car)
    {
        if (car.Description.Length > 2 && car.DailyPrice > 0)
        {
            _carDal.Add(car);
            Console.WriteLine("Araç veritabanına başarıyla eklendi");
        }
        else
        {
            Console.WriteLine("Araç bilgileri hatalı!");
        }
    }
}