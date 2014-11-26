/*
Write SQL statements to delete some of the records from the Users and Groups tables.
*/

DELETE FROM Users
WHERE UserName = 'pesho2'
GO

DELETE FROM Groups
WHERE Name = 'Other Group'
GO