using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager:ICustomerService
{
    private ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public IDataResult<List<Customer>> GetAll()
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
    }

    public IDataResult<Customer> GetById(int id)
    {
        return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id));
    }

    public IResult Insert(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerInserted);
    }

    public IResult Delete(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerDeleted);
    }

    public IResult Update(Customer customer)
    {
        _customerDal.Update(customer);
        return new SuccessResult(Messages.CustomerUpdated);
    }
}