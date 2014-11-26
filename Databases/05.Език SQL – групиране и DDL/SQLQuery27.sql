/*
Write a SQL query to display the town where maximal number of employees work.
*/

SELECT TOP(1) COUNT(e.EmployeeID) AS [Employee Count], t.Name AS [Town]
FROM Employees e
  JOIN Addresses a
    ON e.AddressID = a.AddressID
  JOIN Towns t
    ON a.TownID = t.TownID
	GROUP BY t.Name
	ORDER BY [Employee Count] DESC
