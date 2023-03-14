using eTicket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext() : base()
        {
            this.Database.Connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\acer\\source\\repos\\application\\db\\dataBase.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        
    }
}
