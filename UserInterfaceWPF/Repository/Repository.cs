using System;
using System.Collections.Generic;
using System.Linq;

namespace UserInterfaceWPF.Repository
{
    public class Repository<TEntity, TPKey> : IRepository<TEntity, TPKey> where TEntity : class
    {
        protected readonly DistanceLearningContainer context;

        public Repository(DistanceLearningContainer context)
        {
            this.context = context;
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);

        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);

        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }

        public virtual TEntity Get(TPKey id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            /*    context.Set<TEntity>().Attach(entity);

                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();*/
        }
        /*public DistanceLearningContainer BeginTransaction()
        {
          //  return context.Database.BeginTransaction();
        }*/

        ~Repository()
        {
            context.Dispose();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
