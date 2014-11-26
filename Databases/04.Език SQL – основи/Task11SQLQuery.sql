/*Write a SQL query to find the names of all employees whose first name starts with "SA".*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name]
FROM [TelerikAcademy].[dbo].Employees e
WHERE e.FirstName LIKE 'sa%'