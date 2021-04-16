using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces;
using Core.Entities.Concrate;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
