using SensorMicroservice.ModelInterfaces;
using SensorMicroservice.Models.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    [AlestaTable("RestRoom")]
    public class RestRoom : BaseModel, IModelTimer
    {
        [Column("BeginProcess")]
        public DateTime BeginProcess { get; set; }

        [Column("EndProcess")]
        public DateTime EndProcess { get; set; }

        [Column("Value")]
        public Boolean Value { get; set; }

        public void OnAdd()
        {
            this.BeginProcess = DateTime.Now;
            this.EndProcess = this.BeginProcess;
            this.Value = true;
        }

        public void OnUpdate()
        {
            this.EndProcess = DateTime.Now;
            this.Value = false;
        }

       
    }
}
