using Microsoft.EntityFrameworkCore;
using SensorMicroservice.Context;
using SensorMicroservice.ModelInterfaces;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Repositories
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
    {
        protected readonly SensorDbContext sensorDbContext;

        protected DbSet<TModel> DBSet
        {
            get
            {
                return this.sensorDbContext.Set<TModel>();
            }
        }

        public BaseRepository(SensorDbContext sensorDbContext)
        {
            this.sensorDbContext = sensorDbContext;
        }

        public virtual void Add(TModel model)
        {
            DBSet.Add(model);
            SaveChanges();
        }
        
        public virtual void Delete(TModel model)
        {
            
        }

        public virtual IEnumerable<TModel> GetList()
        {
            return DBSet.ToList();
        }

        public virtual void Update(TModel model)
        {
            throw new NotImplementedException();
        }
        public virtual void SaveChanges() => this.sensorDbContext.SaveChanges();
    }
}
