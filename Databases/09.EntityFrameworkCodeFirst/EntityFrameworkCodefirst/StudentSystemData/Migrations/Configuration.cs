namespace StudentSystemData.Migrations
{
    using StudentSystemModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystemData.StudentSystemDbContext";
        }

        //Task03
        protected override void Seed(StudentSystemDbContext context)
        {
            this.SeedCourses(context);
            this.SeedStudents(context);
        }

        private void SeedStudents(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.Add(new Student
            {
                FirstName = "Arnold",
                LastName = "Schwarzeneger",
                Number = 1
            });

            context.Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Rambo",
                Number = 2,
            });

            context.Students.Add(new Student
            {
                FirstName = "Bratmi",
                LastName = "Rambo",
                Number = 3
            });

            context.Students.Add(new Student
            {
                FirstName = "Silvester",
                LastName = "Stalone",
                Number = 9999
            });
        }

        private void SeedCourses(StudentSystemDbContext context)
        {
            if (context.Courses.Any())
            {
                return;
            }

            context.Courses.Add(new Course
            {
                Name = "Seeded course",
                Description = "Initial course for testing"
            });
        }
    }
}
