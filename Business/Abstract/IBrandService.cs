using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    IDataResult<List<Brand>> GetAll();
    IDataResult<Brand> GetById(int id);
    IResult Insert(Brand brand);
    IResult Delete(Brand brand);
    IResult Update(Brand brand);
    
}