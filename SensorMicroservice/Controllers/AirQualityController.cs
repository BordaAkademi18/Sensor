using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Controllers
{
    [Route("AirQualityMicroservice")]
    public class AirQualityController : Controller
    {

        private readonly IAirQualityRepository repository;

        public AirQualityController(IAirQualityRepository repository)
        {
            this.repository = repository;
        }




    }
}
