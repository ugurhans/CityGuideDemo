using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using Entities.Dtos;

namespace DataAccess.Concrate
{
    public class EfCityDal : EfEntityRepositoryBase<City, CityGuideContext>, ICityDal
    {
        public List<CityForListDTO> GetCityDetails(Expression<Func<CityForListDTO, bool>> filter = null)
        {
            using (CityGuideContext context = new CityGuideContext())
            {
                var result = from c in context.Cities
                             join p in context.Photos on c.Include equals EXPR2
            }
        }
    }
}
