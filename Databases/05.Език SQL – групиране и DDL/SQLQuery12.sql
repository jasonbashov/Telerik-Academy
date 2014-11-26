/*
Write a SQL query to find all employees along with their managers.
For employees that do not have manager display the value "(no manager)".
*/

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	   ISNULL(m.LastName, 'no manager') AS MgrLastName
FROM [TelerikAcademy].[dbo].Employees m
  RIGHT OUTER JOIN [TelerikAcademy].[dbo].Employees e
    ON e.ManagerID = m.EmployeeID