namespace _01.CreatingDbContextNorthwind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //08.By inheriting the Employee entity class create a class which allows employees to access
    //their corresponding territories as property of type EntitySet<T>.
    //The Extended class is in the first project: EmployeeExtended.cs

    class Program
    {
        static void Main()
        {
            var employee = new Employee();
            var dbContext = new NorthwindEntities();

            employee = dbContext.Employees.FirstOrDefault();

            foreach (var teritory in employee.EntityTerritories)
            {
                Console.WriteLine(teritory.TerritoryDescription);
            }

            //I don't understand why we do this when this will return the same result
            Console.WriteLine("And now without using this unnecessary extension");
            foreach (var territory in employee.Territories)
            {
                Console.WriteLine(territory.TerritoryDescription);
            }
        }
    }
}
