/*
Write a SQL query to display the current date and time in the following format 
"day.month.year hour:minutes:seconds:milliseconds". 
Search in  Google to find how to format dates in SQL Server.
*/

SELECT CONVERT(varchar(25), GETDATE(), 113) AS [Current date and time]

SELECT CONVERT(varchar(10), GETDATE(), 104) + ' ' + CONVERT(varchar(12), GETDATE(), 114) AS [Current date and time]