namespace DAL.Migrations
{
    using EFRepo;
    using EFRepo.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFRepo.ProjectDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EFRepo.ProjectDBContext";
        }
    }
}
