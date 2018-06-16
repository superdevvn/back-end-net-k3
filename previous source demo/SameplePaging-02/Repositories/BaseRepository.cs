using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models.Common;

namespace Repositories
{
    //Generic Template C#
    public abstract class BaseRepository<TEntity>
        where TEntity : class
    {
        public virtual TEntity Get(Guid id)
        {
            using (var context = new ApiDbContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public virtual TEntity Create(TEntity entity, Guid? userId = null)
        {
            using (var context = new ApiDbContext())
            {
                Guid id = Guid.NewGuid();
                entity.GetType().GetProperty("Id").SetValue(entity, id);
                context.Set<TEntity>().Add(entity);
                context.SaveChanges(userId);
                return Get(id);
            }
        }

        public virtual TEntity Update(TEntity entity, Guid? userId = null)
        {
            using (var context = new ApiDbContext())
            {
                Guid id = new Guid(entity.GetType().GetProperty("Id").GetValue(entity, null).ToString());
                var entry = context.Set<TEntity>().Find(id);
                // Gán từng giá trị của các thuộc tính entity cho entry
                CloneObject(entry, entity);
                context.SaveChanges(userId);
                return Get(id);
            }
        }

        public virtual IEnumerable GetList()
        {
            using (var context = new ApiDbContext())
            {
                var query = context.Set<TEntity>();
                DbQuery<TEntity> result = null;
                if (typeof(TEntity).GetProperty("Creator") != null)
                    result = query.Include("Creator.Username");
                if (typeof(TEntity).GetProperty("Modifier") != null)
                    result = result.Include("Modifier");
                if (result == null) return query.ToList();
                else return result.ToList();
            }
        }

        public virtual IEnumerable GetList(IEnumerable<string> includes)
        {
            using (var context = new ApiDbContext())
            {
                var query = context.Set<TEntity>();
                DbQuery<TEntity> result = null;
                foreach (string include in includes)
                {
                    result = query.Include(include);
                }
                if (result == null) return query.ToList();
                else return result.ToList();
            }
        }

        private void CloneObject(object des, object src)
        {
            foreach (PropertyInfo propertyInfo in des.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (src.GetType().GetProperty(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance) != null)
                {
                    var value = src.GetType().GetProperty(propertyInfo.Name).GetValue(src, null);
                    propertyInfo.SetValue(des, value, null);
                }
            }
        }
    }
}
