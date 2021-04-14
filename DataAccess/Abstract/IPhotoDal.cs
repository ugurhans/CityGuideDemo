using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAcces;
using Entities.Concrate;

namespace DataAccess.Abstract
{
    public interface IPhotoDal : IEntityRepository<Photo>
    {
    }
}
