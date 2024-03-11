using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class RentalManager:IRentalService
{
    private IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }
    
    public IDataResult<List<Rental>> GetAll()
    {
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
    }

    public IDataResult<Rental> GetById(int id)
    {
        return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
    }

    public IResult Insert(Rental rental)
    {
        Rental rentalCheck = _rentalDal.GetUnreturnedCar(rental.CarId);

        if (rentalCheck == null || rentalCheck.ReturnDate is not null)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CustomerInserted);
        }

        Console.WriteLine(Messages.CarIsNotReturned);
        return new ErrorResult(Messages.CarIsNotReturned);
    }

    public IResult Delete(Rental rental)
    {
        _rentalDal.Delete(rental);
        return new SuccessResult(Messages.CustomerDeleted);
    }

    public IResult Update(Rental rental)
    {
        _rentalDal.Update(rental);
        return new SuccessResult(Messages.CustomerUpdated);
    }
}