/*
Write a SQL statement to create a table Groups. 
Groups should have unique name (use unique 
constraint). Define primary key and identity column. 
*/

CREATE TABLE Groups (
  GroupId int IDENTITY (1, 1),
  Name nvarchar(50) NOT NULL UNIQUE,
  CONSTRAINT PK_Groups PRIMARY KEY(GroupId)
)
GO

