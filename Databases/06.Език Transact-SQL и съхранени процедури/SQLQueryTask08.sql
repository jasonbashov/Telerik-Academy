/*
08.Using database cursor write a T-SQL script that scans all employees
and their addresses and prints all pairs of employees that live in 
the same town.
*/

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT e.FirstName, e.LastName, t.Name, emp.FirstName, emp.LastName
  FROM Employees e
  JOIN Addresses a
  ON e.AddressID = a.AddressID
  JOIN Towns t
  ON a.TownID = t.TownID, 
  Employees emp
  JOIN Addresses ad
  ON emp.AddressID = ad.AddressID
  JOIN Towns t2
  ON ad.TownID = t2.TownID
  WHERE t.Name = t2.Name AND e.EmployeeID != emp.EmployeeID

OPEN empCursor
DECLARE @firstEmpFirstName nvarchar(50), 
		@firstEmpLastName nvarchar(50),
		@townName nvarchar(50),
		@secondEmpFirstName nvarchar(50),
		@secondEmpLastName nvarchar(50)
FETCH NEXT FROM empCursor 
INTO @firstEmpFirstName, @firstEmpLastName, @townName,
	 @secondEmpFirstName, @secondEmpLastName

WHILE @@FETCH_STATUS = 0
  BEGIN
    PRINT @firstEmpFirstName + ' ' + @firstEmpLastName 
	+ ' | ' + @townName + ' | '
	+ @secondEmpFirstName + ' ' + @secondEmpLastName
    FETCH NEXT FROM empCursor 
    INTO @firstEmpFirstName, @firstEmpLastName, @townName,
		 @secondEmpFirstName, @secondEmpLastName
  END

CLOSE empCursor
DEALLOCATE empCursor
