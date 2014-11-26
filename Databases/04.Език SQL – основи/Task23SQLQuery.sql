/*Write a SQL query to find all the employees and the manager for 
each of them along with the employees that do not have manager. 
Use right outer join. Rewrite the query to use left outer join.*/
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], 
	   m.EmployeeID MgrID, m.LastName MgrLastName
FROM [TelerikAcademy].[dbo].Employees m RIGHT OUTER JOIN [TelerikAcademy].[dbo].Employees e
  ON e.ManagerID = m.EmployeeID

SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], 
	   m.EmployeeID MgrID, m.LastName MgrLastName
FROM [TelerikAcademy].[dbo].Employees e LEFT OUTER JOIN [TelerikAcademy].[dbo].Employees m
  ON e.ManagerID = m.EmployeeID