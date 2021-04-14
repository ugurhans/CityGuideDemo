using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrate;

namespace Business.Abstract
{
    interface IPhotoService
    {
        IDataResult<List<Photo>> GetAll();
        IDataResult<Photo> GetById(int photoId);
        IResult Add(Photo photo);
        IResult Delete(Photo photo);
        IResult Update(Photo photo);
        IDataResult<List<Photo>> GetPhotosByCityId(int cityId);

    }
}
