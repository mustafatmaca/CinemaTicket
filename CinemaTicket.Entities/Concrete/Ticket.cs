using CinemaTicket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public int SessionId { get; set; }
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int TicketUnit { get; set; }
        public decimal Price { get; set; }
    }
}
