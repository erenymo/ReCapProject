using DataAccess.Abstract;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Microsoft.Identity.Client;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserDal:EfEntityRepositoryBase<User, RentacarContext>,IUserDal
{
    
}