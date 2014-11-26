/*
07.Define a function in the database TelerikAcademy that returns all 
Employee's names (first or middle or last name) and all town's names 
that are comprised of given set of letters. Example 'oistmiahf' will 
return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
*/

CREATE FUNCTION [dbo].[fn_NameContainingLetters](@name NVARCHAR(50),
  @letters NVARCHAR(50))
  RETURNS bit
AS
BEGIN
	DECLARE @contains bit
	SET @contains = 1
    DECLARE @curLetter NVARCHAR(1)
    DECLARE @counter INT
    SET @counter = 1
 
    WHILE(@counter <= LEN(@name))
		BEGIN
		SET @curLetter = SUBSTRING(@name, @counter, 1)
		IF (CHARINDEX(@curLetter, @letters) = 0)
		        SET @contains = 0
		SET @counter = @counter + 1
		END
    RETURN @contains
END
GO

CREATE PROC [dbo].[usp_FindNames](@lettersToSearch NVARCHAR(50))
AS
	DECLARE @valid bit
	SET @valid = 0
	SELECT e.FirstName AS [FIRST Names]
	FROM Employees e
	WHERE 1 = 
	(SELECT [dbo].[fn_NameContainingLetters](e.FirstName, @lettersToSearch))
GO

CREATE PROC [dbo].[usp_FindMiddleNames](@lettersToSearch NVARCHAR(50))
AS
	DECLARE @valid bit
	SET @valid = 0
	SELECT e.MiddleName AS [Middle Names]
	FROM Employees e
	WHERE 1 = 
	(SELECT [dbo].[fn_NameContainingLetters](e.MiddleName, @lettersToSearch))
GO

CREATE PROC [dbo].[usp_FindLastNames](@lettersToSearch NVARCHAR(50))
AS
	DECLARE @valid bit
	SET @valid = 0
	SELECT e.LastName AS [Last Names]
	FROM Employees e
	WHERE 1 = 
	(SELECT [dbo].[fn_NameContainingLetters](e.LastName, @lettersToSearch))
GO

CREATE PROC [dbo].[usp_FindTownNames](@lettersToSearch NVARCHAR(50))
AS
	DECLARE @valid bit
	SET @valid = 0
	SELECT t.Name AS [Town Names]
	FROM Towns t
	WHERE 1 = 
	(SELECT [dbo].[fn_NameContainingLetters](t.Name, @lettersToSearch))
GO
USE TelerikAcademy
GO

CREATE TABLE Results(ComprisedNames NVARCHAR(50))

INSERT Results ( ComprisedNames )
EXEC [dbo].[usp_FindNames] @letterstosearch = 'oistmiahf'

INSERT Results ( ComprisedNames )
EXEC [dbo].[usp_FindMiddleNames] @letterstosearch = 'oistmiahf'

INSERT Results ( ComprisedNames )
EXEC [dbo].[usp_FindLastNames] @letterstosearch = 'oistmiahf'

INSERT Results ( ComprisedNames )
EXEC [dbo].[usp_FindTownNames] @letterstosearch = 'oistmiahf'

SELECT * FROM Results
GO

DROP TABLE Results
GO

--EXEC [dbo].[usp_FindNames] @letterstosearch = 'oistmiahf'
--EXEC [dbo].[usp_FindMiddleNames] @letterstosearch = 'oistmiahf'
--EXEC [dbo].[usp_FindLastNames] @letterstosearch = 'oistmiahf'
--EXEC [dbo].[usp_FindTownNames] @letterstosearch = 'oistmiahf'