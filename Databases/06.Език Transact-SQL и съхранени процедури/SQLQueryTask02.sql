/*
02.Create a stored procedure that accepts a number as a parameter and 
returns all persons who have more money in their accounts than the
supplied number.
*/

CREATE PROC usp_SelectPersonsWithMoreMoneyThanPassed(
  @minMoneyNeeded int = 500)
AS
  SELECT p.FirstName + ' ' + p.LastName AS [Person name],
  a.Balance
  FROM Persons p
  JOIN Accounts a
  ON p.PersonId = a.PersonId
  WHERE a.Balance >= @minMoneyNeeded
GO

EXEC usp_SelectPersonsWithMoreMoneyThanPassed 510
