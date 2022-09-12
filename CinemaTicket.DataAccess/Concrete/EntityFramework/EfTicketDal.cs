using CinemaTicket.Core.DataAccess.EntityFramework;
using CinemaTicket.DataAccess.Abstract;
using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.DataAccess.Concrete.EntityFramework
{
    public class EfTicketDal : EfEntityRepositoryBase<Ticket, CinemafyContext>, ITicketDal
    {
    }
}
