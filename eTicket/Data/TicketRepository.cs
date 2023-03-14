using eTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{

    public interface ITicketRepo
    {
        IEnumerable<Ticket> GetETickets();
        Ticket GetTicketById(int Id);
        void InsertTicket(Ticket Ticket);
        void DeleteTicket(int Id );
        void UpdateTicket(Ticket Ticket);
        void Save();

    }
    public class TicketRepository : ITicketRepo
    {

        private AppDbContext _context;

        public TicketRepository()
        {
            this._context = new AppDbContext();
        }
        public void DeleteTicket(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetETickets() => this._context.Tickets.ToList();

        public Ticket GetTicketById(int Id)
        {
            throw new NotImplementedException();
        }

        public void InsertTicket(Ticket Ticket)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            this._context.SaveChanges();
        }

        public void UpdateTicket(Ticket Ticket)
        {
            throw new NotImplementedException();
        }
    }
}
