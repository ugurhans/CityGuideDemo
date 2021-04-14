using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAcces;
using Entities.Concrate;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface ICityDal : IEntityRepository<City>
    {
        List<CityForListDTO> GetCityDetails(Expression<Func<CityForListDTO, bool>> filter = null);
    }
}
