using SensorMicroservice.ModelInterfaces;
using SensorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.RepositoryInterfaces
{
    public interface IBaseRepository<TModel> where TModel : BaseModel 
    {

        void Add(TModel model);

        void Update(TModel model);

        void Delete(TModel model);

        IEnumerable<TModel> GetList();

      




    }
}
