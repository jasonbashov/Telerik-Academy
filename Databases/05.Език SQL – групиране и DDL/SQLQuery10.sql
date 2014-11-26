/*
Write a SQL query to find the count of all employees in each department and for each town.
*/

SELECT COUNT(e.EmployeeID) AS [Employee Count], d.Name AS [Dept. Name]
FROM Employees e 
  JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name

SELECT COUNT(e.EmployeeID) AS [Employee Count], t.Name AS [Town]
FROM Employees e
  JOIN Addresses a
    ON e.AddressID = a.AddressID
  JOIN Towns t
    ON a.TownID = t.TownID
	GROUP BY t.Name
