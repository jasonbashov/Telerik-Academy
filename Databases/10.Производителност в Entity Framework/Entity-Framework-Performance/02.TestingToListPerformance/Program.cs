namespace TestingToListPerformance
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    
    using _01.TestingPerformanceWithWithoutInclude;

    class Program
    {
        static void Main()
        {
            var telerikDb = new TelerikAcademyEntities();

            MeasurePerformanceToList(telerikDb);
        }
        
 
        private static void MeasurePerformanceToList(TelerikAcademyEntities telerikDb)
        {
            var stopWatch = new Stopwatch();
            using (telerikDb)
            {
                stopWatch.Start();
                var sofiaEmployees = telerikDb.Employees
                                              .ToList()
                                              .Select(e => e.Address)
                                              .ToList()
                                              .Select(a => a.Town)
                                              .Where(p => p.Name == "Sofia")
                                              .ToList();
                stopWatch.Stop();

                Console.WriteLine("Time taken for the ToList() chaining: {0}", stopWatch.Elapsed);

                stopWatch.Restart();
                var sofiaFastEmployees = telerikDb.Employees.Select(e => e.Address.Town).Where(t => t.Name == "Sofia").ToList();
                stopWatch.Stop();

                Console.WriteLine("Time taken with optimized query: {0}", stopWatch.Elapsed);
            }
        }
    }
}
