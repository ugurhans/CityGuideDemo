using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CityGuideContext>, IUserDal
    {
    }
}
