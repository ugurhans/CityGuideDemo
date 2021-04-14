using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<City> GetById(int cityId);
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);


    }
}
