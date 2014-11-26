/*
Write a SQL query to find the average salary  in the "Sales" department.
*/

SELECT AVG(Salary) AS [Average Salary]
FROM Employees e
JOIN Departments d
ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'
