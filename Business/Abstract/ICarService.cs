using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetCarsByBrandId(int Id);
    List<Car> GetCarsByColorId(int Id);
    List<CarDetailDto> GetCarDetails();
    Car GetById(int Id);
    void Insert(Car car);
    void Delete(Car car);
    void Update(Car car);
}