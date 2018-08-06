using SensorMicroservice.ModelInterfaces;
using SensorMicroservice.Models.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models
{
    [AlestaTable("AirQuality")]
    public class AirQuality : BaseModel
    {
        [Column("Value")]
        public int Value { get; set; }

        [Column("Time")]
        public DateTime Time { get; set; }

        public void onAdd() => this.Time = DateTime.Now;


    }
}
