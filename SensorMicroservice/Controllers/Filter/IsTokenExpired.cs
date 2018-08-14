using Microsoft.AspNetCore.Mvc.Filters;
using SensorMicroservice.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SensorMicroservice.Controllers.Filter
{
    public class IsTokenExpired : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            IEnumerable<Claim> claim = context.HttpContext.User.Claims;
            string claimHwId = claim.ElementAt(0).Value;
            context.ActionArguments.Add("token", TokenAssigner.GetToken(claimHwId));
        }
    }
}
