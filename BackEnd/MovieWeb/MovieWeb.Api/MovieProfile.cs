using AutoMapper;
using MovieWeb.Api.Dto.Movie;
using MovieWeb.Database.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Api
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDatabase, GetMovieDto>();//GET ALL
            CreateMap<MovieDatabase, GetMovieDto>(); //GET BY ID
            CreateMap<PostMovieDto, MovieDatabase>(); //CREATE
            CreateMap<UpdateMovieDto, MovieDatabase>(); //Update
        }
            
    }
}
