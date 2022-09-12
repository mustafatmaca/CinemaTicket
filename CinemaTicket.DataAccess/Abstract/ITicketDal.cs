using CinemaTicket.Core.DataAccess;
using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.DataAccess.Abstract
{
    public interface ITicketDal : IEntityRepository<Ticket>
    {
    }
}
