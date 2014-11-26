/*Write a SQL query to find all information about the employees 
whose job title is “Sales Representative“.*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name], e.JobTitle
FROM [TelerikAcademy].[dbo].Employees e
WHERE e.JobTitle = 'Sales Representative'