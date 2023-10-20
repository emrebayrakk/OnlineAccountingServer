using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Presentation.Controller
{
    public sealed class TestController : ApiController
    {
        [HttpGet]
        public IActionResult GetAction()
        {
            return Ok("true");
        }
    }
}
