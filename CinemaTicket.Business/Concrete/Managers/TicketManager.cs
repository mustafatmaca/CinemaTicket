using CinemaTicket.Business.Abstract;
using CinemaTicket.DataAccess.Abstract;
using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Concrete.Managers
{
    public class TicketManager : ITicketService
    {

        private ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public Ticket Add(Ticket ticket)
        {
            return _ticketDal.Add(ticket);
        }

        public void Delete(Ticket ticket)
        {
            _ticketDal.Delete(ticket);
        }

        public List<Ticket> GetAll()
        {
            return _ticketDal.GetList();
        }

        public Ticket GetById(int id)
        {
            return _ticketDal.Get(t => t.Id == id);
        }

        public List<Ticket> GetTicketsBySalonId(int salonId)
        {
            return _ticketDal.GetList(t => t.SalonId == salonId);
        }

        public Ticket Update(Ticket ticket)
        {
            return _ticketDal.Update(ticket);
        }
    }
}
