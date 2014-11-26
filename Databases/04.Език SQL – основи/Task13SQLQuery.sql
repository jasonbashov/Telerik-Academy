/*Write a SQL query to find the salary of all employees 
whose salary is in the range [20000…30000].*/
SELECT  e.FirstName + ' ' + e.LastName as [Employee Full Name], e.Salary
FROM [TelerikAcademy].[dbo].Employees e
WHERE Salary BETWEEN 20000 AND 30000 
ORDER BY Salary