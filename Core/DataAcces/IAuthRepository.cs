using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAcces
{
    public interface IAuthRepository<T>
        where T : class, IEntity, new()
    {
        Task<T> Register(T entity, string password);
        Task<T> Login(T entity, string password);
        Task<bool> UserExists(string userName);

    }
}
