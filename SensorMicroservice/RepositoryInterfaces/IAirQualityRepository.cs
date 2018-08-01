using Microsoft.EntityFrameworkCore.Metadata;
using SensorMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.RepositoryInterfaces
{
    public interface IAirQualityRepository : IBaseRepository<AirQuality>
    {
        

        AirQuality Get(DateTime TimeBegin, DateTime TimeEnd);
        

    }
}