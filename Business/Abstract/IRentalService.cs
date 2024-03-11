using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IRentalService
{
    IDataResult<List<Rental>> GetAll();
    IDataResult<Rental> GetById(int id);
    IResult Insert(Rental rental);
    IResult Delete(Rental rental);
    IResult Update(Rental rental);
}