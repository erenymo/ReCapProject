using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal:EfEntityRepositoryBase<Brand, RentacarContext>,IBrandDal
{
    
}