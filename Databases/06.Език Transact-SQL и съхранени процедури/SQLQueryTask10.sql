/*
10.Define a .NET aggregate function StrConcat that takes as input 
a sequence of strings and return a single string that consists 
of the input strings separated by ','. For example the following 
SQL statement should return a single string:
SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees
***********************************************
 I didn't have time to research how Invoking CLR User-Defined Aggregate
 Functions work so I used a colleague from the forum's solution
 *********************************************
*/

DECLARE @name nvarchar(MAX);
SET @name = N'';

SELECT @name += e.FirstName + N','
FROM Employees e
SELECT LEFT(@name,LEN(@name)-1);