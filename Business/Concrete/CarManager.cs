using Business.Abstract;
using Business.Constants;
using Business.ValidatorRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public IDataResult<List<Car>> GetAll()
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.CarsListed);
    }

    public IDataResult<List<Car>> GetCarsByColorId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id), Messages.CarsListed);
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarsListed);
    }

    public IDataResult<Car> GetById(int id)
    {
        return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
    }

    [ValidationAspect(typeof(CarValidator))]
    public IResult Insert(Car car)
    {
        
        _carDal.Add(car);
        return new SuccessResult(Messages.CarInserted);
        
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);

    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);

    }
}