/*
Write a SQL query to display the number of managers from each town.
*/

SELECT t.Name as Town, COUNT(e.ManagerID) AS [Managers Number]
FROM Employees e
  JOIN Addresses a
	ON e.AddressID = a.AddressID
	  JOIN Towns t
		ON t.TownID = a.TownID
WHERE e.EmployeeID in
	(SELECT DISTINCT ManagerID
	 FROM Employees)
	 GROUP BY t.Name
	 ORDER BY [Managers Number] DESC
GO
