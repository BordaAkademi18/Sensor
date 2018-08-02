using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class RestRoomController  :  Controller
    {

        private readonly IRestRoomRepository repository;

        public RestRoomController(IRestRoomRepository repository)
        {
            this.repository = repository;
        }

        

        

        

    }
}
