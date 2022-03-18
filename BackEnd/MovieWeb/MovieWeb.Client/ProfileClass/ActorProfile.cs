using AutoMapper;
using MovieWeb.Client.Models;
using MovieWeb.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Client.ProfileClass
{
    public class ActorProfile : Profile
    {
        public ActorProfile()
        {
           CreateMap<ActorDatabase,ActorListViewModel > ();//GET ALL
           CreateMap<ActorDatabase,ActorDetailViewModel > ();//GET by id
           CreateMap<ActorCreateViewModel, ActorDatabase> ();//create
           CreateMap<ActorDatabase, ActorUpdateViewModel> ();//update (id)
            CreateMap<ActorUpdateViewModel, ActorDatabase>();//update (id, table)
            CreateMap<ActorDatabase, ActorDeleteViewModel > ();//delete(id)

        }
    }
}
