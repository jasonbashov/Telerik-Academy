/*
Write a SQL query to display the average employee salary by department and job title.
*/

SELECT AVG(e.Salary) AS [Avg. Emp. Salary], 
	   d.Name AS [Depart. Name],
	   e.JobTitle AS [Emp. Job Title]
FROM [TelerikAcademy].[dbo].Employees e
  JOIN [TelerikAcademy].[dbo].Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name, e.JobTitle
