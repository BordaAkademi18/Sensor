using SensorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.RepositoryInterfaces
{
    public interface ICoffeeRepository : IBaseRepository<Coffee>
    {

        void Converter(Converter input);

        void Clear();

        void Update(Coffee coffee, int level);
    }
}
