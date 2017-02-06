using EFRepo;
using EFRepo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepo
{
    class ProjectDBInitializer : CreateDatabaseIfNotExists<ProjectDBContext>
    {
        protected override void Seed(ProjectDBContext context)
        {
            context.Users.Add(  
                new UserDB { FirstName = "Rowan", LastName = "Miller", Login = "hedr" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
