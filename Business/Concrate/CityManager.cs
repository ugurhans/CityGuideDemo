using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BussinessAspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.Dtos;

namespace Business.Concrate
{
    class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IDataResult<City> GetById(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.Id == cityId));
        }
        [SecuredOperation("city.add,admin")]
        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult();
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult();
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult();
        }

        public IDataResult<List<CityForListDTO>> GetCityDetail()
        {
            return new SuccessDataResult<List<CityForListDTO>>(_cityDal.GetCityDetails());
        }


    }
}
