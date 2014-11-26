/*
09.* Write a T-SQL script that shows for each town a list 
of all employees that live in it. Sample output:
Sofia -> Svetlin Nakov, Martin Kulov, George Denchev
Ottawa -> Jose Saraiva
*/

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT t.Name
  FROM Employees e
  JOIN Addresses a
  ON e.AddressID = a.AddressID
  JOIN Towns t
  ON a.TownID = t.TownID
  GROUP BY t.Name

OPEN empCursor
DECLARE @townName NVARCHAR(50)
	DECLARE @firstName NVARCHAR(50),
			@lastName NVARCHAR(50)
FETCH NEXT FROM empCursor 
INTO @townName

WHILE @@FETCH_STATUS = 0
  BEGIN
    PRINT @townName + ' | '

	DECLARE empCursor2 CURSOR READ_ONLY FOR
	  SELECT emp.FirstName, emp.LastName
	  FROM Employees emp
      JOIN Addresses ad
      ON emp.AddressID = ad.AddressID
      JOIN Towns ut
      ON ad.TownID = ut.TownID
	  WHERE ut.Name = @townName
	  OPEN empCursor2
	  
	   FETCH NEXT FROM empCursor2
	   INTO @firstName, @lastName
        
        WHILE @@FETCH_STATUS = 0
        BEGIN
                PRINT '   ' + @firstName + ' ' + @lastName
                FETCH NEXT FROM empCursor2 INTO @firstName, @lastName
        END
 
        CLOSE empCursor2
        DEALLOCATE empCursor2

    FETCH NEXT FROM empCursor 
    INTO @townName
  END

CLOSE empCursor
DEALLOCATE empCursor
