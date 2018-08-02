using SensorMicroservice.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    public class RestRoom : IModelTimer, BaseModel
    {
        public DateTime BeginProcess { get; set; }
        public DateTime EndProcess { get; set; }
        public int HardwareId { get; set; }
        public int ID { get; set; }
        public Boolean Value { get; set; }

        public void OnAdd()
        {
            this.BeginProcess = DateTime.Now;
            this.Value = true;
        }

        public void OnUpdate()
        {
            this.EndProcess = DateTime.Now;
            this.Value = false;
        }

        public void FromConverterForAdding(Converter converterModel)
        {
            this.HardwareId = Convert.ToInt32(converterModel.ID);
        }
    }
}
