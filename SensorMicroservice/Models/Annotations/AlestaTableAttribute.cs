using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Models.Annotations
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AlestaTableAttribute : TableAttribute
    {
        private static readonly string defaultSchemaName = "Alesta";

        public AlestaTableAttribute(string name) : base(name)
        {
            this.Schema = defaultSchemaName;
        }
    }

}
