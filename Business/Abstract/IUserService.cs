using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int photoId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
     
    }
}
