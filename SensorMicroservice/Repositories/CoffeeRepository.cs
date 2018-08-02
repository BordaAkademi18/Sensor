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

        

        public override void Add(Coffee model)
        {
            


            model.OnAdd();
            
            sensorDbContext.Coffee.Add(model);

            SaveChanges();

        }


        public override void Update(Coffee model)
        {

            

        }

        public override void Delete(Coffee model)
        {
            
        }





        public override IEnumerable<Coffee> GetList()
        {


            return base.GetList();
        }

    }




}
