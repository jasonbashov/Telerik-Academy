/*Write a SQL query to find all employees, along with their manager 
and their address. Join the 3 tables: Employees e, Employees m and Addresses a.*/
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name], 
	   a.AddressText AS [Employee Address],
	   m.FirstName + ' ' + m.LastName AS [Employee's Manager]
FROM [TelerikAcademy].[dbo].Employees e
  JOIN [TelerikAcademy].[dbo].Employees m
	ON e.ManagerID = m.EmployeeID
  JOIN [TelerikAcademy].[dbo].Addresses a
	ON e.AddressID = a.AddressID
	ORDER BY [Employee's Manager]