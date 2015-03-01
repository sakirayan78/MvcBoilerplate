namespace MvcBoilerplate.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcBoilerplate.Model.MvcBoilerplateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcBoilerplate.Model.MvcBoilerplateContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            context.Roles.AddOrUpdate(
             new Role { Id = 1, Rolename = "Admin" });
            //
            context.Users.AddOrUpdate(
             new User
             {
                 Id = 1,
                 RoleId = 1,
                 UserName = "Admin",
                 Password = "Admin",
                 Email = "Admin@Admin",
                 NameSurname = "Admin",
                 City = "ANT",
                 IsActive = true,
                 RememberMe = true
             }
);
        }
    }
}
