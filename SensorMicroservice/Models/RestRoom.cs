using SensorMicroservice.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    public class RestRoom : BaseModel,IModelTimer
    {
        public DateTime BeginProcess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EndProcess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HardwareId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public int Value;
        public void OnAdd()
        {
            throw new NotImplementedException();
        }

        public void OnUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
