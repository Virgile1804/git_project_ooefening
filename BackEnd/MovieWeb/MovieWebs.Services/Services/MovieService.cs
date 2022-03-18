using Microsoft.EntityFrameworkCore;
using MovieWeb.Database;
using MovieWeb.Database.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebs.Services.Services
{
    public class MovieService : IMovieService
    {
        private readonly DatabaseContext _ctx;
        public MovieService(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<MovieDatabase> CreateMoviesAsync(MovieDatabase md)
        {
            var createdMovie = await _ctx.movies.AddAsync(md);
            await _ctx.SaveChangesAsync();
            return md;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var movie = await _ctx.movies.FindAsync(id); //On utilise FindAsync
            if (movie == null) return false;

            _ctx.movies.Remove(movie);
            await _ctx.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<MovieDatabase>> GetMoviesAsync()
        {
            var movies = await _ctx.movies.ToListAsync();
            return movies;
        }

        public async Task<MovieDatabase> GetMoviesAsync(int id)
        {
            var movie = await _ctx.movies.FindAsync(id); //On utilise FindAsync
            return movie;
        }

        public async Task<MovieDatabase> UpdateMovieAsync(int id, MovieDatabase movie)
        {
            var movie2 = await _ctx.movies.FindAsync(id); //On utilise FindAsync
            if (movie == null)
            {
                return null;
            }

            movie2.Name = movie.Name;
            await _ctx.SaveChangesAsync();
            return movie2;
        }

        /*-------------------------------------------*/

        public async Task<bool> AddActor(int id, int idActor)
        {
            try
            {
                var Movie = await _ctx.movies.FindAsync(id);
                var Actor = await _ctx.actors.Include(x=>x.Movies).SingleOrDefaultAsync(x=>x.Id == idActor);
                
                Movie.Actors.Add(Actor);
                await _ctx.SaveChangesAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteActor(int id, int idActor)
        {
            try
            {
                var Movie = await _ctx.movies.FindAsync(id);
                var Actor = await _ctx.actors.Include(x => x.Movies).SingleOrDefaultAsync(x => x.Id == idActor);

                Movie.Actors.Remove(Actor);
                await _ctx.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }



        }
    }
}
