using Business.Abstract;
using Business.Constants;
using Business.ValidatorRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete;

public class ColorManager:IColorService
{
    private IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IDataResult<List<Color>> GetAll()
    {
        return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
    }

    public IDataResult<Color> GetById(int id)
    {
        return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id));
    }

    [ValidationAspect(typeof(ColorValidator))]
    public IResult Insert(Color color)
    { 
        //business codes
        _colorDal.Add(color);
        return new SuccessResult(Messages.ColorInserted);
    }

    public IResult Delete(Color color)
    {
        _colorDal.Delete(color);
        return new SuccessResult(Messages.ColorDeleted);
    }

    public IResult Update(Color color)
    {
        _colorDal.Update(color);
        return new SuccessResult(Messages.ColorUpdated);
    }
}