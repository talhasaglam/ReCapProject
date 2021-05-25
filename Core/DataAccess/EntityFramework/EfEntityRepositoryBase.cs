using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDispossable pattern implementation of C#
            using (TContext context = new TContext()) //Usinge yazarsak  işi bitince direk GC temziler
            {
                var addedEntity = context.Entry(entity); // Veri kaynağımla ilişkiklendirdim.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //Usinge yazarsak  işi bitince direk GC temziler
            {
                var deletedEntity = context.Entry(entity); // Veri kaynağımla ilişkiklendirdim.
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext()) //Usinge yazarsak  işi bitince direk GC temziler
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext()) //Usinge yazarsak  işi bitince direk GC temziler
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //Usinge yazarsak  işi bitince direk GC temziler
            {
                var modifiedEntity = context.Entry(entity); // Veri kaynağımla ilişkiklendirdim.
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
