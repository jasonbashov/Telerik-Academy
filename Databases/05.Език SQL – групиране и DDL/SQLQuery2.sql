/*
Write a SQL query to find the names and salaries of the employees
 that have a salary that is up to 10% higher than the minimal salary for the company.
*/

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
	   e.Salary
FROM Employees e
WHERE Salary <
  (SELECT (MIN(Salary) / 10 + MIN(Salary)) FROM Employees)
  ORDER BY Salary