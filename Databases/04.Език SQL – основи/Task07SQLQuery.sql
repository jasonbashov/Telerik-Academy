/*Write a SQL to find the full name of each employee.*/
SELECT e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName as FullName
FROM [TelerikAcademy].[dbo].Employees e