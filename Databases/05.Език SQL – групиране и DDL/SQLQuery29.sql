/*
Write a SQL to create table WorkHours to store work reports for each employee 
(employee id, date, task, hours, comments). Don't forget to define  identity,
 primary key and appropriate foreign key. Issue few SQL statements to insert,
 update and delete of some data in the table. Define a table WorkHoursLogs to 
 track all changes in the WorkHours table with triggers. For each change keep 
 the old record data, the new record data and the command (insert / update / delete).
*/

CREATE TABLE WorkHours (
  WorkHoursId int IDENTITY (1,1),
  EmployeeId int,
  WorkDate datetime,
  Task nvarchar(200),
  WorkHours TIME,
  Comments nvarchar(200),
  CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId),
  CONSTRAINT FK_WorkHours_Employees FOREIGN KEY (EmployeeID)
  REFERENCES Employees(EmployeeId),
)

CREATE TABLE WorkHoursLog(
Id int IDENTITY,
OldRecord nvarchar(200),
NewRecord nvarchar(200),
Command nvarchar(10),
CONSTRAINT PK_WorkHoursLog PRIMARY KEY(Id)
)
GO

--DROP TRIGGER tr_WorkHoursInsert;
--GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLog(OldRecord, NewRecord, Command)
VALUES(' ', 
(SELECT 'Day: ' + CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + ' Hours: ' +
CAST([WorkHours] AS nvarchar(50)) + ' ' + CAST([WorkHours] AS nvarchar(50)) + ' ' + Comments
FROM Inserted),
'INSERT'
);
GO

--DROP TRIGGER tr_WorkHoursUpdate;
--GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLog(OldRecord, NewRecord, Command)
VALUES((SELECT 'Day: ' + CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + ' Hours: ' +
CAST([WorkHours] AS nvarchar(50)) + ' ' + Comments
FROM Deleted),
(SELECT 'Day: ' + CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + ' Hours: ' +
CAST([WorkHours] AS nvarchar(50)) + ' ' + Comments
FROM Inserted),
'UPDATE'
);
GO

--DROP TRIGGER tr_WorkHoursDeleted;
--GO

CREATE TRIGGER tr_WorkHoursDeleted ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLog(OldRecord, NewRecord, Command)
VALUES(
(SELECT 'Day: ' + CAST(WorkDate AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + ' Hours: ' +
CAST([WorkHours] AS nvarchar(50)) + ' ' + Comments
FROM Deleted),
' ',
'DELETE'
);
GO

INSERT INTO WorkHours(EmployeeId, WorkDate, Task, WorkHours, Comments)
VALUES (111, GETDATE(), 'chop down some trees', '02:00:00', 'ASAP')
GO

INSERT INTO WorkHours(EmployeeId, WorkDate, Task, WorkHours, Comments)
VALUES (10, GETDATE(), 'Fix bug #256', '23:00:00', 'No commits before bug fixed')
GO
INSERT INTO WorkHours(EmployeeId, WorkDate, Task, WorkHours, Comments)
VALUES (12, GETDATE(), 'Implement Composite pattern', '02:00:00', '15% bonus')
GO
INSERT INTO WorkHours(EmployeeId, WorkDate, Task, WorkHours, Comments)
VALUES (13, GETDATE(), 'Add like button to the form', '05:00:00', 'No bonus')
GO

DELETE FROM WorkHours
WHERE Task LIKE '%bug #256%';

UPDATE WorkHours
SET WorkHours = '22:22:22'
WHERE Task LIKE '%like button%';
GO
