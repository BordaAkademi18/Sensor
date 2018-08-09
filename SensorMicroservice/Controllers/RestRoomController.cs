using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.Models;
using SensorMicroservice.RepositoryInterfaces;
using System.Collections.Generic;


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
        [HttpPost]
        public void Post([FromBody]Converter model)
        {
            //string noticicationServiceBaseUrl = "http://localhost:40040";
            //this.repository.PostToAnotherService(model, noticicationServiceBaseUrl, "api/restRoomTest");
            this.repository.PostRequest(model);
        }



    }
}
