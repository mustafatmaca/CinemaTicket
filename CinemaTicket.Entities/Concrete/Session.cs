using CinemaTicket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Entities.Concrete
{
    public class Session : IEntity
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public string SessionTime { get; set; }
        public string FilmName { get; set; }
    }
}
