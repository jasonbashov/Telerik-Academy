/*
Write a SQL query to find the number of all employees that have no manager.
*/

SELECT  COUNT(FirstName) AS [Employees without manager count]
FROM [TelerikAcademy].[dbo].Employees e
WHERE ManagerID IS NULL
