/*
Write a SQL query to find the number of all employees that have manager.
*/

SELECT  COUNT(FirstName) AS [Employees with manager count]
FROM [TelerikAcademy].[dbo].Employees e
WHERE ManagerID IS NOT NULL
