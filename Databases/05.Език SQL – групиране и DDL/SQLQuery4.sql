/*
Write a SQL query to find the average salary in the department #1.
*/

SELECT AVG(Salary) AS [Average Salary]
FROM Employees e
WHERE DepartmentID = 1
