using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba_sigma.Infraestructure;

namespace prueba_sigma.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        public CommandResult Get()
        {
            return new CommandResult(true, "success");
        }

    }
}
