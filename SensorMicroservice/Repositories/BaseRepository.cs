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

        public BaseRepository(SensorDbContext sensorDbContext)
        {
            this.sensorDbContext = sensorDbContext;
        }

        public virtual void Add(TModel model)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TModel> GetList()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TModel model)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveChanges() => this.sensorDbContext.SaveChanges();
    }
}
