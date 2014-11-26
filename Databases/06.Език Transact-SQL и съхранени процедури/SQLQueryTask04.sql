/*
04.Create a stored procedure that uses the function from the previous example 
to give an interest to a person's account for one month. It should take the
 AccountId and the interest rate as parameters.
*/

USE TelerikAcademy
GO

CREATE PROC dbo.usp_GiveInterestForOneMonth(
  @AccountId int = 1,
  @InterestRate float = 0.05)
AS
  SELECT dbo.ufn_CalcInterest(a.Balance, @InterestRate, 1) AS [New Sum]
  FROM  Accounts a
  WHERE a.AccountId = @AccountId
GO

EXEC dbo.usp_GiveInterestForOneMonth 1, 0.05
EXEC dbo.usp_GiveInterestForOneMonth 2, 0.05
EXEC dbo.usp_GiveInterestForOneMonth 3, 0.05
EXEC dbo.usp_GiveInterestForOneMonth 4, 0.05
GO
