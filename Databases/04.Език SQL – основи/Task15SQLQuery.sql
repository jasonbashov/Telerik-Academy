/*Write a SQL query to find all employees that do not have manager.*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name], e.ManagerID
FROM [TelerikAcademy].[dbo].Employees e
WHERE ManagerID IS NULL