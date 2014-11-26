/*
Start a database transaction, delete all employees from the 'Sales'
 department along with all dependent records from the pother tables.
  At the end rollback the transaction.
*/

-- Delete contraints before execution
BEGIN TRAN
DELETE FROM Employees 
WHERE DepartmentId IN 
(SELECT DepartmentId 
FROM Departments WHERE Name = 'Sales')
ROLLBACK TRAN
GO
