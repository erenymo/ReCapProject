using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetCarsByBrandId(int Id);
    List<Car> GetCarsByColorId(int Id);
    Car GetById(int Id);
    void Insert(Car car);
    void Delete(Car car);
    void Update(Car car);
}