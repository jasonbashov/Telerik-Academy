namespace StudentSystemData
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystemModel;
    using StudentSystemData.Migrations;

    //Task01
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
            : base ("StudentSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
        }
        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }
    }
}
