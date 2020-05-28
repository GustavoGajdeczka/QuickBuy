﻿using QuickBuy.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public void Create(TEntity entity) {
            throw new NotImplementedException();
        }
        public void Update(TEntity entity) {
            throw new NotImplementedException();
        }
        public void Delete(TEntity entity) {
            throw new NotImplementedException();
        }
        public void Dispose() {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> GetAll() {
            throw new NotImplementedException();
        }
        public TEntity GetById(int id) {
            throw new NotImplementedException();
        }

    }
}
