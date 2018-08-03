using Microsoft.EntityFrameworkCore;
using SensorMicroservice.Context;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Repositories
{
    public class CoffeeRepository : BaseRepository<Coffee>, ICoffeeRepository
    {

       

        public CoffeeRepository(SensorDbContext sensorDbContext) : base(sensorDbContext)
        {
            
        }





        public void Converter(Converter input)
        {

            int HardId = Convert.ToInt32(input.ID);

            int level = Convert.ToInt32(input.Value);


            this.Add(new Coffee
            {
                HardwareId = HardId,

                CurrentLevel = level
            });



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

            return this.DBSet.ToList()
        }

    }




}
