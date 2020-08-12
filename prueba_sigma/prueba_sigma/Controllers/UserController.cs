using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba_sigma.Infraestructure;
using prueba_sigma.Models;

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


        [HttpPost("sendData")]
        public CommandResult sendData(User user)
        {
            return new CommandResult(true, "Información almacenada correctamente");
        }
    }
}
