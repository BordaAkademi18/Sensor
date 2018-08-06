using SensorMicroservice.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    public class AirQuality : BaseModel
    {

        public int Value { get; set; }
        public DateTime Time { get; set; }

    }
}
