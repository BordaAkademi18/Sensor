using SensorMicroservice.Context;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Repositories
{
    public class AirQualityRepository : BaseRepository<AirQuality>, IAirQualityRepository
    {
        public AirQualityRepository(SensorDbContext sensorDbContext) : base(sensorDbContext) { }

        public AirQuality Get(DateTime TimeBegin, DateTime TimeEnd)
        {
            throw new NotImplementedException();
        }

        public void PostRequest(AirQuality model)
        {
            model.onAdd();
            Add(model);
        }

        public IEnumerable<AirQuality> GetBetweenTwoDates(string startTimeString, string endTimeString)
        {
            DateTime startTime = ToDateTimeFromString(startTimeString);
            DateTime endTime = ToDateTimeFromString(endTimeString);

            var modelList= DBSet.Where(model => model.Time > startTime && model.Time < endTime);
            return modelList;
        }

        private DateTime ToDateTimeFromString(string date)
        {
            //year-month-day like "2011-03-21"
            return DateTime.Parse(date);
        }


    }


}


