using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;

namespace Business.Concrate
{
    public class PhotoManager : IPhotoService
    {
        private IPhotoDal _photoDal;

        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public IDataResult<List<Photo>> GetAll()
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll());
        }

        public IDataResult<Photo> GetById(int photoId)
        {
            return new SuccessDataResult<Photo>(_photoDal.Get(p => p.Id == photoId));
        }

        public IResult Add(Photo photo)
        {
            _photoDal.Add(photo);
            return new SuccessResult();
        }

        public IResult Delete(Photo photo)
        {
            _photoDal.Delete(photo);
            return new SuccessResult();
        }

        public IResult Update(Photo photo)
        {
            _photoDal.Update(photo);
            return new SuccessResult();
        }

        public IDataResult<List<Photo>> GetPhotosByCityId(int cityId)
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll(p => p.CityId == cityId));
        }
    }
}
