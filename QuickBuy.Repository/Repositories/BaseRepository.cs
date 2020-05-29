using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly QuickBuyContext QuickBuyContext;
        public BaseRepository(QuickBuyContext quickBuyContext) {
            QuickBuyContext = quickBuyContext;
        }
        public void Create(TEntity entity) {
            QuickBuyContext.Set<TEntity>().Add(entity);
            QuickBuyContext.SaveChanges();
        }
        public void Update(TEntity entity) {
            QuickBuyContext.Set<TEntity>().Update(entity);
            QuickBuyContext.SaveChanges();
        }
        public void Delete(TEntity entity) {
            QuickBuyContext.Remove(entity);
            QuickBuyContext.SaveChanges();
        }
        public void Dispose() {
            QuickBuyContext.Dispose();
        }
        public IEnumerable<TEntity> GetAll() {
            return QuickBuyContext.Set<TEntity>().ToList();
        }
        public TEntity GetById(int id) {
            return QuickBuyContext.Set<TEntity>().Find(id);
        }

    }
}
