using SensorMicroservice.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    public class Coffee : IModelTimer, BaseModel
    {
        public DateTime BeginProcess { get ; set ; }
        public DateTime EndProcess { get ; set ; }
        public int HardwareId { get; set; }
        public int ID { get; set; }


        public int CurrentLevel;

        public void OnAdd()
        {

            BeginProcess = DateTime.Now;

            EndProcess = null;
        
        }

        public void OnUpdate()
        {
            


        }
    }
}
