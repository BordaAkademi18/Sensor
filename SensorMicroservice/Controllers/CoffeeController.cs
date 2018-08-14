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
        [Route("Post")]
        public IActionResult Post([FromBody]Converter item)
        {
            if (item == null)
            {
                return BadRequest();
                
            }

            
            this.repository.Converter(item);

        

            
            return Ok(item);
        }

        [HttpGet]
        [Route("Get")]
        public IEnumerable<Coffee> Get()
        {
         
            return this.repository.GetList();

        }

        [Route("Clear")]
        public void Clear()
        {
             
            this.repository.Clear();
        }




    }
}
