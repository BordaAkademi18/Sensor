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
    }
}
