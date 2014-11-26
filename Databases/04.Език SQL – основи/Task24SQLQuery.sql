/*Write a SQL query to find the names of all employees from the departments
 "Sales" and "Finance" whose hire year is between 1995 and 2005.*/
SELECT e.FirstName + ' ' + e.LastName AS [Emp. Name],
	   d.Name AS [Department],
	   e.HireDate
FROM  [TelerikAcademy].[dbo].Employees e
	JOIN [TelerikAcademy].[dbo].Departments d
	ON (e.DepartmentID = d.DepartmentID
		AND (d.Name = 'Sales' OR d.Name = 'Finance')
		AND (e.HireDate BETWEEN '1/1/1995' AND '1/1/2005'))
