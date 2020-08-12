using Microsoft.AspNetCore.Mvc;
using prueba_sigma.Infraestructure;
using prueba_sigma.Models;
using prueba_sigma.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba_sigma.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CitiesController : Controller
    {

        [HttpGet("States")]
        public async Task<CommandResult<List<string>>> GetStates()
        {
            DepartmentService service = new DepartmentService();
            var states = await service.getStates();

            return new CommandResult<List<string>>(true, "success", states.Keys.ToList());
        }

        [HttpGet("GetCitiesByStateId")]
        public async Task<CommandResult<List<string>>> GetCitiesByStateId(string state)
        {
            DepartmentService service = new DepartmentService();
            Dictionary<string, string[]> states = await service.getStates();
            if(states.ContainsKey(state))
            {
                return new CommandResult<List<string>>(true, "success", states[state].ToList());
            }

            return new CommandResult<List<string>>(false, "El departamento no existe", null);
        }
    }
}
