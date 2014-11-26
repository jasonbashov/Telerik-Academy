/*
Write a SQL query to display the minimal employee salary by department 
and job title along with the name of some of the employees that take it.
*/

SELECT d.Name AS [Depart. Name],
	   e.JobTitle AS [Emp. Job Title],
	   e.FirstName + ' ' + e.LastName AS [Emp. Name],
	   e.Salary
FROM [TelerikAcademy].[dbo].Employees e
  JOIN [TelerikAcademy].[dbo].Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE e.Salary =
	(SELECT MIN(emp.Salary) FROM Employees emp
	WHERE e.DepartmentID = emp.DepartmentID)