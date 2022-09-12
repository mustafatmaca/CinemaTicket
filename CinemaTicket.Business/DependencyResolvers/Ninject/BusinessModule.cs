using CinemaTicket.Business.Abstract;
using CinemaTicket.Business.Concrete.Managers;
using CinemaTicket.DataAccess.Abstract;
using CinemaTicket.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITicketService>().To<TicketManager>().InSingletonScope();
            Bind<ISalonService>().To<SalonManager>().InSingletonScope();
            Bind<ISessionService>().To<SessionManager>().InSingletonScope();

            Bind<ITicketDal>().To<EfTicketDal>().InSingletonScope();
            Bind<ISalonDal>().To<EfSalonDal>().InSingletonScope();
            Bind<ISessionDal>().To<EfSessionDal>().InSingletonScope();
        }
    }
}
