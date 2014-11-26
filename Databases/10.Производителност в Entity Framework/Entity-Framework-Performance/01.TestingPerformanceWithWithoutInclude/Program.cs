namespace TestingPerformanceWithWithoutInclude
{
    using _01.TestingPerformanceWithWithoutInclude;
    using System;
    using System.Diagnostics;
    using System.Linq;

    //01.Using Entity Framework write a SQL query to select all employees from the Telerik Academy 
    //database and later print their name, department and town. Try the both variants: with and without 
    //.Include(…). Compare the number of executed SQL statements and the performance.

    //02.Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
    //then invokes ToList(), then selects their addresses, then invokes ToList(), then selects their towns,
    //then invokes ToList() and finally checks whether the town is "Sofia". Rewrite the same in more optimized
    //way and compare the performance.

    class Program
    {
        static void Main()
        {
            var telerikDb = new TelerikAcademyEntities();

            MeasurePerformance(telerikDb);
        }
 
        private static void MeasurePerformance(TelerikAcademyEntities telerikDb)
        {
            var stopWatch = new Stopwatch();

            using (telerikDb)
            {
                stopWatch.Start();
                foreach (var emp in telerikDb.Employees)
                {
                    Console.WriteLine("Employee: {0} {1} from department: {2}, city: {3}", emp.FirstName, emp.LastName, emp.Department.Name, emp.Address.Town.Name);
                }
                stopWatch.Stop();
                var firstMeasurementWithoutInlude = stopWatch.Elapsed;

                stopWatch.Restart();
                foreach (var emp in telerikDb.Employees.Include("Department").Include("Address"))
                {
                    Console.WriteLine("Employee: {0} {1} from department: {2}, city: {3}", emp.FirstName, emp.LastName, emp.Department.Name, emp.Address.Town.Name);
                }
                stopWatch.Stop();
                Console.WriteLine("Time taken without Include(): {0}", firstMeasurementWithoutInlude);
                Console.WriteLine("Time taken with Include(): {0}", stopWatch.Elapsed);
            }
        }
    }
}
