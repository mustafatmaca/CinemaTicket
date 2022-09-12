using CinemaTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Abstract
{
    public interface ISalonService
    {
        List<Salon> GetAll();
        List<Salon> GetSalonsById(List<int> salonId);
        Salon GetById(int id);
        Salon Add(Salon salon);
        Salon Update(Salon salon);
        void Delete(Salon salon);
    }
}
