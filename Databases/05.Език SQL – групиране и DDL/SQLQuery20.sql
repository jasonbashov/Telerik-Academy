/*
Write SQL statements to update some of the 
records in the Users and Groups tables. 
*/

UPDATE Users
SET Username='goshoOtPochivka', UserPassword='654321'
WHERE Username='gosho2' AND UserPassword='123456';
GO

UPDATE Groups
SET Name='updatedFirst'
WHERE Name='First2'
GO