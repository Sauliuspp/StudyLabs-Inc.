using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBStuddyBuddy.Entities;

namespace DBStuddyBuddy.Controllers
{
    [Route("webSBController")]
    [ApiController]
    public class webSBController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world!";
        }

        [HttpPost]
        public string Post([FromBody] AStuddy )
        {
            return "Hello world!";
        }
    }
}