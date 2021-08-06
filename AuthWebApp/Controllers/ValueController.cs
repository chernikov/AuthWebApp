using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthWebApp.Controllers
{
    [Route("/api/value")]
    public class ValueController : Controller
    {

        public IActionResult Get()
        {
            var result = new[]
            {
                "value1", "value2"
            };
            return Ok(result);
        }
    }
}
