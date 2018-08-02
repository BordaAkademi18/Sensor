using SensorMicroservice.Context;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Repositories
{
    public class CoffeeRepository:BaseRepository<Coffee>,ICoffeeRepository
    {
        public CoffeeRepository(SensorDbContext sensorDbContext):base(sensorDbContext)
        {

        }


        
    }




}
