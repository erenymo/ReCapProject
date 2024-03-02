using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetCarsByBrandId(int Id);
    List<Car> GetCarsByColorId(int Id);
    void AddCar(Car car);
}