using System;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        RedisRepository RedisRepository { get; set; }
        void Save();
    }
}