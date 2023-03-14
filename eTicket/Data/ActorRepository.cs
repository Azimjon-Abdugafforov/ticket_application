using eTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{

    public interface IRepository
    {
        IEnumerable<Actor> GetActors();
        Actor GetActorById(int Id);
        void InsertActor(Actor Actor);
        void UpdateActor(Actor Actor);
        void DeleteActor(int Id);
        void Save();
    }
    public class ActorRepository : IRepository
    {
        public AppDbContext ctx;
        public ActorRepository()
        {
            this.ctx = new AppDbContext();
        }

        public void DeleteActor(int Id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorById(int Id)
        {
            return this.ctx.Actors.Find(Id);
        }

        public IEnumerable<Actor> GetActors() => ctx.Actors.ToList();

        public void InsertActor(Actor Actor)
        {
            this.ctx.Actors.Add(Actor);
            this.Save();
        }
        public void UpdateActor(Actor Actor)
        {
            this.ctx.Entry(Actor).State = System.Data.Entity.EntityState.Modified;
            this.Save();
        }

        public void Save()
        {
            this.ctx.SaveChanges();
        }
    }
}
