using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Abstract
{
    public interface ITicketService
    {
        List<Ticket> GetAll();
        List<Ticket> GetTicketsBySalonId(int salonId);
        Ticket GetById(int id);
        Ticket Add(Ticket ticket);
        Ticket Update(Ticket ticket);
        void Delete(Ticket ticket);
    }
}
