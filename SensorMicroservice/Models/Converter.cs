using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    public class Converter
    {
        public string ID { get; set; }

        public string Value { get; set; }

        public string ControlKey { get; set; }

        public bool CompareKeys(string key)
        {
            if (this.ControlKey == key)
                return true;
            else
                return false;
        }
    }
}
