/*Write a SQL query to find the names of all employees whose last name contains "ei".*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name]
FROM [TelerikAcademy].[dbo].Employees e
WHERE e.LastName LIKE '%ei%'