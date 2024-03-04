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

    public List<Car> GetCarsByBrandId(int id)
    {
        return _carDal.GetAll(p => p.BrandId == id);
    }

    public List<Car> GetCarsByColorId(int id)
    {
        return _carDal.GetAll(p => p.ColorId == id);
    }

    public Car GetById(int id)
    {
        return _carDal.Get(c => c.Id == id);
    }

    public void Insert(Car car)
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

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }
}