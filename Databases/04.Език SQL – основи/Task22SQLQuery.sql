/*Write a SQL query to find all departments and all town names as a single list. Use UNION.*/
SELECT 'DEPART: ' + d.Name AS [Departments and Towns]
FROM [TelerikAcademy].[dbo].Departments d
UNION ALL
SELECT 'TOWN: ' + t.Name
FROM [TelerikAcademy].[dbo].Towns t