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

        private readonly ICoffeeRepository repository;

        public CoffeeController(ICoffeeRepository repository)
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



            //this.repository.Add(item);  Continue here
            return Ok(item);
        }
        


    }
}
