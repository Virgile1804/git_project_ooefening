using Microsoft.EntityFrameworkCore;
using MovieWeb.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWebs.Services.Services
{
    public class ActorService : IActorService
    {
        private readonly DatabaseContext _ctx;
        public ActorService(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<ActorDatabase> CreateActorsAsync(ActorDatabase ad)
        {
            var createdActor = await _ctx.actors.AddAsync(ad);
            await _ctx.SaveChangesAsync();
            return ad;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var actor = await _ctx.actors.FindAsync(id); //On utilise FindAsync
            if(actor == null) return false;

            _ctx.actors.Remove(actor);
            await _ctx.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ActorDatabase>> GetActorsAsync()
        {
            var actors = await _ctx.actors.ToListAsync();
            return actors;
        }

        public async Task<ActorDatabase> GetActorsAsync(int id)
        {
            var actor = await _ctx.actors.FindAsync(id); //On utilise FindAsync
            return actor;
        }

        public async Task<ActorDatabase> UpdateActorAsync(int id, ActorDatabase actor) // Dans le service on appelle la classe tandis que dans le controller on utilise le dto
        {
            var actor2 = await _ctx.actors.FindAsync(id); //On utilise FindAsync
            if (actor == null)
            {
                return null;
            }

            actor2.FirstName = actor.FirstName;
            actor2.LastName = actor.LastName;
            await _ctx.SaveChangesAsync();
            return actor2;
        }
    }
}
