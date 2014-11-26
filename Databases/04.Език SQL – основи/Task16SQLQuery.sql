/*Write a SQL query to find all employees that have salary more than 50000.
Order them in decreasing order by salary.*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name], e.Salary
FROM [TelerikAcademy].[dbo].Employees e
WHERE Salary >= 50000 ORDER BY Salary DESC