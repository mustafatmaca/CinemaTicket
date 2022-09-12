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
    public class SessionManager : ISessionService
    {

        private ISessionDal _sessionDal;

        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal;
        }

        public Session Add(Session session)
        {
            return _sessionDal.Add(session);
        }

        public void Delete(Session session)
        {
            _sessionDal.Delete(session);
        }

        public List<Session> GetAll()
        {
            return _sessionDal.GetList();
        }

        public Session GetById(int id)
        {
            return _sessionDal.Get(s => s.Id == id);
        }

        public List<Session> GetListByFilmName(string filmName)
        {
            return _sessionDal.GetList(s => s.FilmName == filmName);
        }

        public List<Session> GetListByFilmNameAndSalonId(string filmName, int salonId)
        {
            return _sessionDal.GetList(s => s.FilmName == filmName && s.SalonId == salonId);
        }

        public List<Session> GetListBySalonId(int id)
        {
            return _sessionDal.GetList(s => s.SalonId == id);
        }

        public Session Update(Session session)
        {
            return _sessionDal.Update(session);
        }
    }
}
