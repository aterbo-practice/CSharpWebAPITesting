using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MSLearnWebAPI.Models;
using MSLearnWebAPI.Services;

namespace MSLearnWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }
        
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if(pizza == null)
                return NotFound();
            
            return pizza;
        }
    }

}