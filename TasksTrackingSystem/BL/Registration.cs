using Autofac;
using EFRepo;
using EFRepo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class Registration
    {
        static Autofac.IContainer container;

        static Registration()
        {
            Registrate();
        }

        public static IRepository<UserDB> UserRepository
        {
            get
            {
                return container.Resolve<IRepository<UserDB>>();
            }
        }

        static void Registrate()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType(typeof(EFRepository<UserDB>)).As(typeof(IRepository<UserDB>));

            container = builder.Build();
        }
    }
}
