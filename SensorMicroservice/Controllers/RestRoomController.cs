using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.Controllers.Filter;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace SensorMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class RestRoomController : Controller
    {

        private readonly IRestRoomRepository repository;

        public RestRoomController(IRestRoomRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public List<Converter> Get()
        {
            return repository.GetRequest();
        }

        [Authorize]
        [IsTokenExpired]
        [HttpPost]
        public string Post([FromBody]Converter model, string token)
        {
            this.repository.PostRequest(model);
            return token;
        }



    }
}
