/*
Write a SQL query to find the full name, salary and department of the employees 
that take the minimal salary in their department. Use a nested SELECT statement.
*/

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	   e.Salary, DepartmentID
FROM Employees e
WHERE Salary =
  (SELECT MIN(Salary) FROM Employees 
   WHERE DepartmentID = e.DepartmentID)
ORDER BY DepartmentID
