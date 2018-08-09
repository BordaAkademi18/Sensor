using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class AirQualityController : Controller
    {

        private readonly IAirQualityRepository repository;

        public AirQualityController(IAirQualityRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("dates")] //like http://localhost:51238/api/airquality/dates?starttime=2011-03-21&endtime=2017-12-22
        public IEnumerable GetBetweenTwoDates(string startTime, string endTime)
        {
            return this.repository.GetBetweenTwoDates(startTime, endTime);
        }

        [Authorize]
        [HttpPost]
        public IActionResult PostFromHardware([FromBody]Converter convertModel)
        {
            AirQuality airQualityModel = new AirQuality();
            airQualityModel.FromConverterForAdding(convertModel);
            this.repository.PostRequest(airQualityModel);
            return Ok();
        }

    }
}
