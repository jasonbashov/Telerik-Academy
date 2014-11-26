--Task 01 Stored Procedure: 
--Write a stored procedure that selects the full names of all persons.
USE TelerikAcademy
GO

CREATE PROC dbo.usp_SelectFullName
AS
  SELECT p.FirstName + ' ' + p.LastName AS [Person Full Name]
  FROM  Persons p
GO

EXEC dbo.usp_SelectFullName
