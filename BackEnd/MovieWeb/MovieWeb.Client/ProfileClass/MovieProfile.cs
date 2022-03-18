using AutoMapper;
using MovieWeb.Client.Models.Movie;
using MovieWeb.Database.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.ProfileClass
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDatabase, MovieListViewModel>();//GET ALL
            CreateMap<MovieDatabase, MovieDetailViewModel>();//GET by id
            CreateMap<MovieCreateViewModel, MovieDatabase>();//create
            CreateMap<MovieDatabase, MovieUpdateViewModel>();//update (id)
            CreateMap<MovieUpdateViewModel, MovieDatabase>();//update (id, table)
            CreateMap<MovieDatabase, MovieDeleteViewModel>();//delete(id)

        }
    }
}
