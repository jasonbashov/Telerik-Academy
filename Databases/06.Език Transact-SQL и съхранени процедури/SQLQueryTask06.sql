/*
06.Create another table – Logs(LogID, AccountID, OldSum, NewSum). 
Add a trigger to the Accounts table that enters a new entry into the
 Logs table every time the sum on an account changes.
*/

CREATE TABLE Logs (
  LogID int IDENTITY (1,1),
  AccountID int,
  OldSum money,
  NewSum money,
  CONSTRAINT PK_Logs PRIMARY KEY(LodID),
  CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountID)
  REFERENCES Accounts(AccountId)
)
GO

--DROP TRIGGER tr_AccountBalanceUpdate;
--GO

CREATE TRIGGER tr_AccountBalanceUpdate ON Accounts FOR UPDATE
AS
INSERT INTO Logs(AccountID, OldSum, NewSum)
SELECT d.AccountID, d.Balance, i.Balance
  FROM deleted AS d
  JOIN inserted AS i
    ON d.AccountID = i.AccountID
GO
