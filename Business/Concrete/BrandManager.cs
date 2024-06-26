using Business.Abstract;
using Business.Constants;
using Business.ValidatorRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    private IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public IDataResult<List<Brand>> GetAll()
    {
        return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
    }

    public IDataResult<Brand> GetById(int id)
    {
        return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id));
    }

    [ValidationAspect(typeof(BrandValidator))]
    public IResult Insert(Brand brand)
    {
        _brandDal.Add(brand);
        return new SuccessResult(Messages.BrandInserted);
    }

    public IResult Delete(Brand brand)
    {
        _brandDal.Delete(brand);
        return new SuccessResult(Messages.BrandDeleted);

    }

    public IResult Update(Brand brand)
    {
        _brandDal.Update(brand);
        return new SuccessResult(Messages.BrandUpdated);

    }
}