namespace StudentSystemConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    using StudentSystemData;
    using StudentSystemModel;

    //Task02
    class StudentSystemConsoleClient
    {
        static void Main()
        {
            var dbContext = new StudentSystemDbContext();
            dbContext.Database.Initialize(true);

            var student = new Student()
            {
                FirstName = "Gosho",
                LastName = "Peshov",
                Number = 10
            };

            student.Courses.Add(new Course
            {
                Name = "Java",
                Description = "Go, go java rangers"
            });

            student.Homeworks.Add(new Homework
            {
                Content = "The dog ate my homework, again",
                TimeSpent = 5
            });

            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }
    }
}
