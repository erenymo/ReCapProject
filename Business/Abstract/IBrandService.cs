using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    List<Brand> GetAll();
    Brand GetById(int id);
    void Insert(Brand brand);
    void Delete(Brand brand);
    void Update(Brand brand);
    
}