using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba_sigma.Context;
using prueba_sigma.Infraestructure;
using prueba_sigma.Models;

namespace prueba_sigma.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext context;
        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public CommandResult Get()
        {
            var data = context.Users.ToList();
            return new CommandResult(true, "success");
        }


        [HttpPost("sendData")]
        public CommandResult sendData(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return new CommandResult(true, "Tu información ha sido recibida satisfactoriamente");
        }
    }
}
