/*
Write a SQL query to find all departments and the average salary for each of them.
*/

SELECT AVG(e.Salary) AS [Avg. Salary], d.DepartmentID
FROM Employees e 
  JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
	GROUP BY d.DepartmentID
