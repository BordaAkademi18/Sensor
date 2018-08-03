using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.ModelInterfaces
{
    public abstract class BaseModel
    {

        public int HardwareId { get; set; }

        public int ID { get; set; }


    }
}
