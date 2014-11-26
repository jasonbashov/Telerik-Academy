/*Write a SQL query to find the top 5 best paid employees.*/
SELECT TOP 5 e.FirstName + ' ' + e.LastName as [Employee Full Name], e.Salary
FROM [TelerikAcademy].[dbo].Employees e
ORDER BY Salary DESC