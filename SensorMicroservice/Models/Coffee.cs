﻿using SensorMicroservice.ModelInterfaces;
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
        public int CurrentLevel { get; set; }


        public void OnAdd()
        {

            BeginProcess = DateTime.Now;

            EndProcess = DateTime.Now;
        
           
        }

        public void OnUpdate()
        {

            EndProcess = DateTime.Now;
            

        }

        private void OnUpdate(int level)
        {



        }

    }
}
