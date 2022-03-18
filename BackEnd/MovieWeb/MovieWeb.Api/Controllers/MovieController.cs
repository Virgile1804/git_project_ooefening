using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Api.Dto.Movie;
using MovieWeb.Database.Movie;
using MovieWebs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api.Controllers
{
    [ApiController]
    [Route("Api/Movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _MovieService;
        private readonly IMapper _Mapper;

        public MovieController(IMovieService MovieService, IMapper Mapper)
        {
            _MovieService = MovieService;
            _Mapper = Mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMovieDto>>> Movies() //Pour afficher tous les acteurs
        {
            var movies = await _MovieService.GetMoviesAsync();

            
            var movieDtos = _Mapper.Map<IEnumerable<GetMovieDto>>(movies);


            return Ok(movieDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<GetMovieDto>>> Movies(int id) //Pour récupérer par ID
        {
            var movie = await _MovieService.GetMoviesAsync(id);

            if (movie == null)
            {
                return NotFound();
            }
            

            var movieDtosById = _Mapper.Map<GetMovieDto>(movie);
            return Ok(movieDtosById);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PostMovieDto movieDto)
        {

            var movie = _Mapper.Map<MovieDatabase>(movieDto);

            if (movie == null)
                return BadRequest();

            var createdMovie = _MovieService.CreateMoviesAsync(movie);

            return CreatedAtAction(nameof(Movies), new { id = movie.Id });

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<GetMovieDto>> Update([FromRoute] int id, [FromBody] UpdateMovieDto movieDto)
        {
            
            var md = _Mapper.Map<MovieDatabase>(movieDto);
            var movie = await _MovieService.UpdateMovieAsync(id, md);

            return Ok(movie);


        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<GetMovieDto>> Delete([FromRoute] int id)
        {
            var movie = await _MovieService.DeleteAsync(id);

            if (movie == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }





        }

        [HttpPost("{id:int}/Actor")]
        public async Task<ActionResult<GetMovieDto>> AddActor([FromRoute] int id, [FromBody] GetIdMovieDto idActor)
        {
            
            var movie = await _MovieService.AddActor(id, idActor.Id);

            if(movie == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        [HttpDelete("{id:int}/Actor")]
        public async Task<ActionResult<GetMovieDto>> DeleteActor ([FromRoute] int id, [FromBody] GetIdMovieDto idActor)
        {
            var delActorOfMovie = await _MovieService.DeleteActor(id, idActor.Id);
            

            if (delActorOfMovie == false)
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
