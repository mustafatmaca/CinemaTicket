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
    public class SalonManager : ISalonService
    {
        private ISalonDal _salonDal;
        public List<Salon> salons { get; set; }

        public SalonManager(ISalonDal salonDal)
        {
            _salonDal = salonDal;
            salons = new List<Salon>();
        }

        public Salon Add(Salon salon)
        {
            return _salonDal.Add(salon);
        }

        public void Delete(Salon salon)
        {
            _salonDal.Delete(salon);
        }

        public List<Salon> GetAll()
        {
            return _salonDal.GetList();
        }

        public Salon GetById(int id)
        {
            return _salonDal.Get(s => s.Id == id);
        }

        public List<Salon> GetSalonsById(List<int> salonId)
        {
            foreach (var id in salonId)
            {
                salons.Add(_salonDal.Get(s => s.Id == id));
            }
            return salons;
        }

        public Salon Update(Salon salon)
        {
            return _salonDal.Update(salon);
        }
    }
}
