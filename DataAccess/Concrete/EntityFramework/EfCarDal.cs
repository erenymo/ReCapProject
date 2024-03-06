using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal:EfEntityRepositoryBase<Car, RentacarContext>,ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (RentacarContext context = new RentacarContext())
        {
            var result = from car in context.Cars
                join brand in context.Brands on car.BrandId equals brand.Id
                join color in context.Colors on car.ColorId equals color.Id
                select new CarDetailDto
                {
                    Name = car.Description,
                    BrandName = brand.Name,
                    ColorName = color.Name,
                    DailyPrice = car.DailyPrice
                };
            return result.ToList();
        }
    }
}