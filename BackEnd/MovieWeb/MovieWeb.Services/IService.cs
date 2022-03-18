using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieWeb;

namespace MovieWeb.Services
{
    public interface IService
    {
        Task<IEnumerable<ActorDatabase>> GetActorAsync();
    }
}
