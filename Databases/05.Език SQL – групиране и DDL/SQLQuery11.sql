/*
Write a SQL query to find all managers that have exactly 5 employees. 
Display their first name and last name.
*/

SELECT m.FirstName + ' ' + m.LastName AS [Mngr. Name]
FROM Employees e 
  INNER JOIN Employees m
    ON m.EmployeeID = e.ManagerID
	GROUP BY m.FirstName, m.LastName
	HAVING COUNT(e.EmployeeID) = 5