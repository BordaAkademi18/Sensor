using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Controllers
{
    [Route("api/[controller]")]
    public class CoffeeController : Controller
    {

        private readonly ICoffeeRepository repository;

        public CoffeeController(ICoffeeRepository repository)
        {
            this.repository = repository;
        }




    }
}
