using AutoMapper;
using MovieWeb.Api.Dto;
using MovieWeb.Database;

namespace MovieWeb.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<ActorDatabase, GetActorDto>();//GET ALL
            CreateMap<ActorDatabase, GetActorDto>(); //GET BY ID
            CreateMap<PostActorDto, ActorDatabase>(); //CREATE
            CreateMap<UpdateActorDto, ActorDatabase>(); //Update
        }
    }
}