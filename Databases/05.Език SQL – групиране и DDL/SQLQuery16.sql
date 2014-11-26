/*
Write a SQL statement to create a view that displays 
the users from the Users table that have been in the 
system today. Test if the view works correctly. 
*/

CREATE VIEW [Users view] AS
SELECT *
FROM [TelerikAcademy].[dbo].Users
WHERE UserLastLoginTime = CONVERT(nvarchar(10), GETDATE(), 120)
GO

