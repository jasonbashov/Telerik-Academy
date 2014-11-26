/*
Write SQL statements to insert in the Users table the names of all 
employees from the Employees table. Combine the first and last names as a full name.
 For username use the first letter of the first name + the last name (in lowercase). 
 Use the same for the password, and NULL for last login time.
*/


INSERT INTO Users([Username], [UserPassword], [UserFullName], [UserLastLoginTime], [GroupId])
SELECT CONVERT(nvarchar(50), LOWER(SUBSTRING(e.FirstName, 1, 1) + e.LastName)), 
	   CONVERT(nvarchar(50), LOWER(SUBSTRING(e.FirstName, 1, 1) + e.LastName)),
	   CONVERT(nvarchar(50), e.FirstName + ' ' + e.LastName),
	   NULL,
	   NULL
FROM Employees e