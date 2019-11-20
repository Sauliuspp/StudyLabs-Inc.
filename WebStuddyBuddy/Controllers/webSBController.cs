using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStuddyBuddy;

namespace WebStuddyBuddy.Controllers
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
        public object Post([FromBody] AStuddyBuddy buddy)
        {
            string name = buddy.Nickname;

            return new
            {
                Status = "Successfully did the thing",
                Buddy = buddy
            };
        }

        /*
        [HttpPost]
        public object Post([FromBody] AStuddyBuddy[] buddies)
        {
            string name = buddy.Nickname;

            return new
            {
                Status = "Successfully did the thing",
                Buddy = buddies
            };
        }
        */
    }
}