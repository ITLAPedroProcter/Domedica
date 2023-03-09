using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebService.Controllers
{
    [Route("/")]
    public class HelloController : Controller
    {
        private const string MESSAGE_FORMAT = "Hello {0}!";

        [HttpGet]
        public JsonResult Get([FromQuery] string name = "World")
        {
            return Json(new Response(string.Format(MESSAGE_FORMAT, name)));
        }
        
        [HttpGet("api/test/")]
        public JsonResult Get([FromQuery] string name = "World")
        {
            return Json(new Response("OMG"));
        }

        [HttpPost]
        public JsonResult Post([FromBody]string name = "World")
        {
            return Json(new Response(string.Format(MESSAGE_FORMAT, name)));
        }
    }
}
