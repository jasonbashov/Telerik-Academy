/*
Write a SQL statement that changes the password to NULL for all users 
that have not been in the system since 10.03.2010.
*/

UPDATE Users SET UserPassword = NULL
WHERE UserLastLoginTime < CONVERT(DATE, '2010.03.10', 102)