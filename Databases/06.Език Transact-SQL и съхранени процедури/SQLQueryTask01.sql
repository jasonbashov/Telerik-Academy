/*
01.Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN)
and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing.
Write a stored procedure that selects the full names of all persons.
*/

CREATE TABLE Persons(
	PersonId int IDENTITY (1,1),
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	SSN int UNIQUE NOT NULL,
	CONSTRAINT PK_Persons PRIMARY KEY(PersonId),
)
GO

CREATE TABLE Accounts(
	AccountId int IDENTITY(1,1),
	PersonId int NOT NULL,
	Balance money,
	CONSTRAINT PK_Accounts PRIMARY KEY(AccountId),
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY(PersonId)
	REFERENCES Persons(PersonId)
)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES ('Gosho', 'Goshev', 123456789)
INSERT INTO Accounts(PersonId, Balance)
VALUES (1, 100)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES ('Pesho', 'Peshev', 123456799)
INSERT INTO Accounts(PersonId, Balance)
VALUES (2, 500)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES ('Stamat', 'Stamatov', 123456889)
INSERT INTO Accounts(PersonId, Balance)
VALUES (3, 550)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES ('Maria', 'Marieva', 133456789)
INSERT INTO Accounts(PersonId, Balance)
VALUES (4, 1200)
GO