/*
03.Create a function that accepts as parameters – sum, yearly 
interest rate and number of months. It should calculate and return
 the new sum. Write a SELECT to test whether the function works as expected.
*/
USE TelerikAcademy
GO

CREATE FUNCTION ufn_CalcInterest(@sum int, @yearlyInterest float, @months int)
  RETURNS money
AS
BEGIN
  DECLARE @answer money 
  SET @answer = @sum + (@months*@sum*@yearlyInterest)
  RETURN @answer
END
GO

SELECT dbo.ufn_CalcInterest(1000, 0.05, 10) AS [New Sum]
GO