using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IRentalDal:IEntityRepository<Rental>
{
    Rental GetUnreturnedCar(int carId);
}