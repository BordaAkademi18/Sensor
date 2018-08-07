using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.Models;
using SensorMicroservice.Repositories;
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

        private readonly CoffeeRepository repository;

        public CoffeeController(CoffeeRepository repository)
        {
            this.repository = repository;
        }


        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Converter item)
        {
            if (item == null)
            {
                return BadRequest();
            }


            this.repository.Converter(item);

        

            
            return Ok(item);
        }
        


    }
}
