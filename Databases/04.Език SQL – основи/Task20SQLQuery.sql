/*Write a SQL query to find all employees along with their manager.*/
SELECT e.FirstName + ' ' + e.LastName AS [Employee Full Name], 
	   m.FirstName + ' ' + m.LastName AS [Employee's Manager] 
FROM [TelerikAcademy].[dbo].Employees e
  INNER JOIN [TelerikAcademy].[dbo].Employees m
	ON e.ManagerID = m.EmployeeID