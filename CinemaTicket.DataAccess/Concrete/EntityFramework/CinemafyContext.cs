using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.DataAccess.Concrete.EntityFramework
{
    public class CinemafyContext : DbContext
    {

        public CinemafyContext()
        {
            Database.SetInitializer<CinemafyContext>(null);
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Session> Sessions { get; set; }

    }
}
