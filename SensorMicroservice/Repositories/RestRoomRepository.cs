using SensorMicroservice.Context;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Repositories
{
    public class RestRoomRepository:BaseRepository<RestRoom>,IRestRoomRepository
    {
        public RestRoomRepository(SensorDbContext sensorDbContext):base(sensorDbContext)
        {

        }
    }
}
