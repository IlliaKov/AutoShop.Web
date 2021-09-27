using AutoShop.DAL.ABSTRACT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AutoShop.DAL.IMPL
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected AutoShopContext _dbContext;
        private DbSet<TEntity> dbEntity;

        public GenericRepository(AutoShopContext dbContext)
        {
            _dbContext = dbContext;
            dbEntity = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            dbEntity.Add(obj);
        }

        public void Delete(object manufactureId)
        {
            TEntity model = dbEntity.Find(manufactureId);
            dbEntity.Remove(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbEntity.ToList();
        }

        public TEntity GetById(object manufactureId)//different find
        {
            return dbEntity.Find(manufactureId);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
