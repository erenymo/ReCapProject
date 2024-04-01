using Business.Abstract;
using Business.Constants;
using Business.ValidatorRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete;

public class UserManager:IUserService
{
    private IUserDal _userDal;

    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public IDataResult<List<User>> GetAll()
    {
        return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
    }

    public IDataResult<User> GetById(int id)
    {
        return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
    }

    [ValidationAspect(typeof(UserValidator))]
    public IResult Insert(User user)
    {
        _userDal.Add(user);
        return new SuccessResult(Messages.UserInserted);
    }

    public IResult Delete(User user)
    {
        _userDal.Add(user);
        return new SuccessResult(Messages.UserDeleted);
    }

    public IResult Update(User user)
    {
        _userDal.Update(user);
        return new SuccessResult(Messages.UserUpdated);
    }
}