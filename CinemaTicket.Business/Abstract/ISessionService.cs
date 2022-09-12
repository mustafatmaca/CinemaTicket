using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Abstract
{
    public interface ISessionService
    {
        List<Session> GetAll();
        List<Session> GetListBySalonId(int id);
        List<Session> GetListByFilmName(string filmName);
        List<Session> GetListByFilmNameAndSalonId(string filmName, int salonId);
        Session GetById(int id);
        Session Add(Session session);
        Session Update(Session session);
        void Delete(Session session);
    }
}
