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
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrate
{
    public class EfCityDal : EfEntityRepositoryBase<City, CityGuideContext>, ICityDal
    {
        public List<CityForListDTO> GetCityDetails(Expression<Func<CityForListDTO, bool>> filter = null)
        {
            using (CityGuideContext context = new CityGuideContext())
            {
                var result = from c in context.Cities
                             join p in context.Photos
                                 on c.Id equals p.CityId
                             select new CityForListDTO
                             {
                                 Name = c.Name,
                                 Id = c.Id,
                                 Description = c.Description,
                                 PhotoUrl = p.Url
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

    }
}
