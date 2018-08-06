using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpPost]
        public void RestRoomPost([FromBody]Converter model)
        {
            this.repository.PostRequest(model);
        }



    }
}
