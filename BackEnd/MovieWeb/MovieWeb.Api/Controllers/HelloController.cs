using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieWeb.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api.Controllers
{
    [ApiController] //Pour avoir des auto complétions d'API
    [Route("Api/Hello")] //On définit la route URL donc ca commence par localhost://xxxxx/Api/Hello
    public class HelloController : ControllerBase //implémente le controller de base pour dire que c'est un controller
    {
        private readonly IConfiguration _configuration;
        public HelloController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("World")] //on récupère quelque chose afin de l'afficher (Api/Hello/world sur internet)
        public ActionResult<string> World()
        {
            return "Hello World";
        }

        [HttpGet("World2")]
        public ActionResult<string> World2([FromQuery] string name) //Fromquery est optionel, et va juste envoyer le nom si on le tape dans l'url (world2?name=Virgile)
        {
            return "Hello, " + name;
        }
        [HttpGet("Developer")]
        public ActionResult<string> Developer()
        {
            var firstname = _configuration["FirstName"];
            var lastname = _configuration["LastName"];

            return Ok(new DeveloperDto()
            {
                FirstName = firstname,
                LastName = lastname
            });
        }


    }
}
