using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.ModelInterfaces
{
    public interface IModelTimer
    {

        DateTime BeginProcess { get; set; }

        DateTime EndProcess { get; set; }

        void OnAdd();

        void OnUpdate();

    }
}
