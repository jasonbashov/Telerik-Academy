/*
Find how to use temporary tables in SQL Server.
 Using temporary tables backup all records from EmployeesProjects
 and restore them back after dropping and re-creating the table.
*/

USE TelerikAcademy;
CREATE TABLE #BackUpEmployeesProjects(
 EmployeeID INT NOT NULL,
 ProjectID INT NOT NULL,
 CONSTRAINT PK_BackUpEmployeesProjects PRIMARY KEY (EmployeeID, ProjectID),
);

INSERT INTO #BackUpEmployeesProjects
SELECT * FROM EmployeesProjects;
DROP TABLE EmployeesProjects;

CREATE TABLE EmployeesProjects(
 EmployeeID INT NOT NULL,
 ProjectID INT NOT NULL,
 CONSTRAINT PK_EmployeeesProjects PRIMARY KEY (EmployeeID, ProjectID),
 CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY (EmployeeID)
 REFERENCES Employees(EmployeeId),
 CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY (ProjectID)
 REFERENCES Projects(ProjectId)
);

INSERT INTO EmployeesProjects
SELECT * FROM #BackUpEmployeesProjects;
GO
