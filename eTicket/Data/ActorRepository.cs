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
        void InsertActor();
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
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetActors() => this.ctx.Actors.ToList();

        public void InsertActor()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            this.ctx.SaveChanges();
        }
    }
}
