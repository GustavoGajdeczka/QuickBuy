using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Contracts
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
