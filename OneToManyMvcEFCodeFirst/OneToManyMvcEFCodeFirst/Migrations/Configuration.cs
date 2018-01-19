namespace OneToManyMvcEFCodeFirst.Migrations
{
    using OneToManyMvcEFCodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OneToManyMvcEFCodeFirst.Models.UniversityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OneToManyMvcEFCodeFirst.Models.UniversityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Departments.AddOrUpdate(
                new Department() { Id=1,Code="SE",Name="Software Engineering"},
                new Department() { Id=1,Code="CS",Name="Computer Science"},
                new Department() { Id=1,Code="CE",Name="Computer Engineering"}
                );
        }
    }
}
