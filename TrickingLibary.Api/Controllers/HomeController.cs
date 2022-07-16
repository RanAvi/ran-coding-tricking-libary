using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickingLibary.Api.Controllers
{

    [ApiController]
    [Route("api/home")]
    public class HomeController  : ControllerBase
    {

        [HttpGet]
          public  string Index() {
            return "Hello world";
        }


    }
}
