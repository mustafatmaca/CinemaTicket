using CinemaTicket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Entities.Concrete
{
    public class Salon  : IEntity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
    }
}
