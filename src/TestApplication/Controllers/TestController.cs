using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        {

        }

        [HttpGet]
        public string Greeting()
        {
            return "Hello Bogdan";
        }

        [HttpGet]
        public string Greeting2(string name)
        {
            return $"Hello {name}";
        }

        [HttpGet]
        public string NewGreeting()
        {
            return "Hi, just testing my CI/CD";
        }
    }
}