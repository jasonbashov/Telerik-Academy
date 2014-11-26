/*
Write a SQL query to find the number of employees in the "Sales" department.
*/

SELECT COUNT(EmployeeID) AS [Employee's Count]
FROM Employees e
JOIN Departments d
ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
