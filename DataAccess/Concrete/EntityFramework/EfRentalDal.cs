using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfRentalDal:EfEntityRepositoryBase<Rental, RentacarContext>,IRentalDal
{
    public Rental GetUnreturnedCar(int carId)
    {
        using (RentacarContext context = new RentacarContext())
        {
            var result = context.Set<Rental>().Where(r => r.CarId == carId && r.ReturnDate == null);

            return result.SingleOrDefault();
        }
    }
}