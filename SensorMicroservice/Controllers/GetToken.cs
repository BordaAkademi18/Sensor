using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensorMicroservice.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorMicroservice.Controllers
{

    [Route("api/[controller]")]
    public class GetTokenController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody]HWClient client)
        {
            if (client.Password.Equals("Vj;LPYAGVb2[Dz~I;Lc7ldpB^5ljh8"))
                return Ok(TokenAssigner.GetToken(client.HwId));
            else
                return BadRequest();
        }

    }
}
