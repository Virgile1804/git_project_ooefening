using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Api.Dto;
using MovieWeb.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieWebs.Services;
using MovieWebs.Services.Services;
using AutoMapper;

namespace MovieWeb.Api.Controllers
{
    [ApiController]
    [Route("Api/Actors")]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _AService;
        private readonly IMapper _Mapper;
        public ActorController(IActorService AService, IMapper Mapper) //On appelle le contexte afin de l'utiliser
        {
            _AService = AService;
            _Mapper = Mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetActorDto>>> Actors() //Pour afficher tous les acteurs
        {
            var actors = await _AService.GetActorsAsync();

            /*var actorDtos = actors.Select(x => new GetActorDto() {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName
            });*/

            //Le mapper va remplacer ce qu'il y a au dessus
            var actorDtos = _Mapper.Map <IEnumerable<GetActorDto>>(actors);


            return Ok(actorDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<GetActorDto>>> Actors(int id) //Pour récupérer par ID
        {
            var actor = await _AService.GetActorsAsync(id);

            if (actor == null)
            {
                return NotFound();
            }
            /*var actorDtosById = new GetActorDto()
            {
                Id = actor.Id,
                FirstName = actor.FirstName,
                LastName = actor.LastName
            }*/

            var actorDtosById = _Mapper.Map<GetActorDto>(actor);
            return Ok(actorDtosById);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PostActorDto actorDto)
        {

            /*var actor = new ActorDatabase()
            {
                FirstName = actorDto.FirstName,
                LastName = actorDto.LastName
            };*/

            var actor = _Mapper.Map<ActorDatabase>(actorDto);

            if (actor == null)
                return BadRequest();

            var createdActor = _AService.CreateActorsAsync(actor);

            return CreatedAtAction(nameof(Actors), new { id = actor.Id });

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<GetActorDto>> Update([FromRoute] int id,[FromBody] UpdateActorDto actorDto)
        {
            /*ActorDatabase ad = new ActorDatabase {
                FirstName = actorDto.FirstName,
                LastName = actorDto.LastName
            };*/
            var ad = _Mapper.Map<ActorDatabase>(actorDto);
            var actor = await _AService.UpdateActorAsync(id, ad);
           
            return Ok(actor);


        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<GetActorDto>> Delete([FromRoute] int id)
        {
            var actor = await _AService.DeleteAsync(id);

            if (actor == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }

            
            


        }


    }
}
