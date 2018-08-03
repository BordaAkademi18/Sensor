using SensorMicroservice.Context;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Repositories
{
    public class AirQualityRepository : BaseRepository<AirQuality>, IAirQualityRepository
    {
        public AirQualityRepository(SensorDbContext sensorDbContext) : base(sensorDbContext)
        {

        }
        public AirQuality Get(DateTime TimeBegin, DateTime TimeEnd)
        {
            throw new NotImplementedException();
        }
    }


}


