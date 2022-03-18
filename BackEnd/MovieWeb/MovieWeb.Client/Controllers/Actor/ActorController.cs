using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Client.Models;
using MovieWeb.Database;
using MovieWebs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _AService;
        private readonly IMapper _Mapper;
        public ActorController(IActorService AService, IMapper Mapper) //On appelle le service afin de l'utiliser
        {
            _AService = AService;
            _Mapper = Mapper;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await _AService.GetActorsAsync();

            var actorsList = _Mapper.Map<IEnumerable<ActorListViewModel>>(actors);

            return View(actorsList);
        }

        public async Task<IActionResult> Details(int id)
        {
            var actor = await _AService.GetActorsAsync(id);

            var actorDetail = _Mapper.Map<ActorDetailViewModel>(actor);

            return View(actorDetail);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ActorCreateViewModel model)
        {
            if (!TryValidateModel(model))
            {
                return View(model);
            }
            var actor = _Mapper.Map<ActorDatabase>(model);

            await _AService.CreateActorsAsync(actor);

            return RedirectToAction(nameof(Index)); //Redirige vers le controller index (notre liste)
        }

        public async Task<IActionResult> Update(int id) //Va récupérer l'id de l'acteur qu'on souhaite modifier, comme ça on peut savoir ce qu'il y avait avant
        {
            var actor = await _AService.GetActorsAsync(id);
            return View(_Mapper.Map<ActorUpdateViewModel>(actor));
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,[FromForm] ActorUpdateViewModel updateModel)
        {
            if (!TryValidateModel(updateModel))
            {
                return View(updateModel);
            }
            var actor = _Mapper.Map<ActorDatabase>(updateModel);

            await _AService.UpdateActorAsync(id,actor);

            return RedirectToAction(nameof(Details), new { Id = id }); 
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var actor = await _AService.GetActorsAsync(id);
            if(actor == null)
            {
                return NotFound();
            }else
            return View(_Mapper.Map<ActorDeleteViewModel>(actor));
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var actor = await _AService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
