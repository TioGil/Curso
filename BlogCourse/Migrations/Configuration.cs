namespace BlogCourse.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogCourse.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogCourse.Models.ApplicationDbContext context)
        {
            context.Blogs.AddOrUpdate(  
                    b => b.Name,
                    new Models.Blog { Name = "Blog Uno" },
                    new Models.Blog { Name = "Blog Dos" }
                );
        }
    }
}
