using Entities.Concrete;

namespace Business.Abstract;

public interface IColorService
{
    List<Color> GetAll();
    Color GetById(int id);
    void Insert(Color color);
    void Delete(Color color);
    void Update(Color color);
}