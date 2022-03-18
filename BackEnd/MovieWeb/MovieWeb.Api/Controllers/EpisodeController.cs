using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using MovieWeb.Api.Dto;

using MovieWebs.Services;

using NetFlow.Api.Dto.Episose;
using NetFlow.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetFlow.Api.Controllers
{
    [ApiController]
    [Route("Api/Episode")]
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeService _AService;
        private readonly IMapper _Mapper;
        public EpisodeController(IEpisodeService AService, IMapper Mapper) //On appelle le contexte afin de l'utiliser
        {
            _AService = AService;
            _Mapper = Mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllEpisodeDto>>> Episode() //Pour afficher tous les acteurs
        {
            var episode = await _AService.GetActorsAsync();

            /*var actorDtos = actors.Select(x => new GetActorDto() {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName
            });*/

            //Le mapper va remplacer ce qu'il y a au dessus
            var actorDtos = _Mapper.Map<IEnumerable<GetActorDto>>(actors);


            return Ok(actorDtos);
        }
      /*  public IActionResult Index()
        {
            return View();
        }*/
    }
}
