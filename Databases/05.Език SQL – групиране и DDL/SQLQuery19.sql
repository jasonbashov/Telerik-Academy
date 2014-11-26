/*
Write SQL statements to insert several records in the Users and Groups tables.
*/

INSERT INTO [TelerikAcademy].[dbo].Groups
VALUES ('Inserted group'),('Other Group'),('First2')

INSERT INTO [TelerikAcademy].[dbo].Users
VALUES ('pesho2', '123456', 'Pesho Peshev', GETDATE(), 1)