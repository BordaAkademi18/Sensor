using SensorMicroservice.ModelInterfaces;
using SensorMicroservice.Models.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    [AlestaTable("Coffee")]
    public class Coffee : BaseModel, IModelTimer
    {
        [Column("BeginProcess")]
        public DateTime BeginProcess { get ; set ; }

        [Column("EndProcess")]
        public DateTime EndProcess { get ; set ; }


        public int CurrentLevel { get; set; }


        public void OnAdd()
        {

            this.BeginProcess = DateTime.Now;

            this.EndProcess = DateTime.Now;
        
           
        }

        public void OnUpdate()
        {

            this.EndProcess = DateTime.Now;
            

        }

        private void OnUpdate(int level)
        {



        }

    }
}
