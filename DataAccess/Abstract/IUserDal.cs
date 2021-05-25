using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        //Join olacağı için operasyon var
        List<OperationClaim> GetClaims(User user);
    }
}
