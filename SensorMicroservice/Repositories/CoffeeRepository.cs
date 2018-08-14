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

            //Get the latest entry from coffee set.

            Coffee latestCoffee = this.DBSet
                             .Where(x
                                 => x.HardwareId == HardId)
                              .OrderByDescending(x => x.ID)
                             .Take(1)
                             .FirstOrDefault();

            if (latestCoffee == null)
            {
                this.Add(new Coffee
                {
                    HardwareId = HardId,

                    CurrentLevel = level
                });

                return;
            }

            //if level is decreasing then update the latest entry and if coffee is emptied then add a new row to the database table

            if (latestCoffee.CurrentLevel > level)
            {
                this.Update(latestCoffee,level);

                if(level == 0)
                {
                    this.Add(new Coffee
                    {
                        HardwareId = HardId,

                        CurrentLevel = level
                    });
                }

            }

            //if level is increasing then update the latest entry in the data set.
            else if (latestCoffee.CurrentLevel < level)
            {

                this.Update(latestCoffee,level);
                   
            }
            
        }



        public override void Add(Coffee model)
        {
            model.OnAdd();

            DBSet.Add(model);

            SaveChanges();

        }


        public override void Update(Coffee model)
        {

           

        }

        public void Update(Coffee model , int level)
        {
            model.OnUpdate(level);

            SaveChanges();

        }

        public override void Delete(Coffee model)
        {

        }


        public void Clear(){

            foreach (var entity in this.DBSet)
                this.DBSet.Remove(entity);
                SaveChanges();

        }





        public override IEnumerable<Coffee> GetList()
        {

            return this.DBSet.ToList();
        }

    }




}
