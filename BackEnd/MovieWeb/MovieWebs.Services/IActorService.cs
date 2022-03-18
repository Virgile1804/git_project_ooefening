using MovieWeb.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebs.Services
{
    public interface IActorService
    {
        Task<IEnumerable<ActorDatabase>> GetActorsAsync();
        Task<ActorDatabase> GetActorsAsync(int id);
        Task<ActorDatabase> CreateActorsAsync(ActorDatabase ad);
        Task<bool> DeleteAsync(int id);
        Task<ActorDatabase> UpdateActorAsync(int id, ActorDatabase actor);
        


    }
}
