using MovieWeb.Database.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebs.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDatabase>> GetMoviesAsync();
        Task<MovieDatabase> GetMoviesAsync(int id);
        Task<MovieDatabase> CreateMoviesAsync(MovieDatabase ad);
        Task<bool> DeleteAsync(int id);
        Task<MovieDatabase> UpdateMovieAsync(int id, MovieDatabase movie);
        Task<bool> AddActor(int id, int idMovie);
        Task<bool> DeleteActor(int id, int idActor);


    }
}
