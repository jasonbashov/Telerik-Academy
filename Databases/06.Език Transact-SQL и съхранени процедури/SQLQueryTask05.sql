/*
05.Add two more stored procedures WithdrawMoney( AccountId, money) and 
DepositMoney (AccountId, money) that operate in transactions.
*/

USE TelerikAcademy
GO

CREATE PROC dbo.usp_WithdrawMoney(
  @AccountId int = 1,
  @amount money = 0)
AS
DECLARE @curBalance money
        SET @curBalance = (
                SELECT a.Balance
                FROM dbo.Accounts a
                WHERE a.AccountID = @AccountID
                )
  UPDATE dbo.Accounts
  SET Balance = @curBalance - @amount
  WHERE Accounts.AccountId = @AccountId
GO

BEGIN TRAN
EXEC dbo.usp_WithdrawMoney 1, 23
EXEC dbo.usp_WithdrawMoney 2, 230
EXEC dbo.usp_WithdrawMoney 3, 123
EXEC dbo.usp_WithdrawMoney 4, 523
COMMIT TRAN
GO

CREATE PROC dbo.usp_DepositMoney(
  @AccountId int = 1,
  @amount money = 0)
AS
DECLARE @curBalance money
        SET @curBalance = (
                SELECT a.Balance
                FROM dbo.Accounts a
                WHERE a.AccountID = @AccountID
                )
  UPDATE dbo.Accounts
  SET Balance = @curBalance + @amount
  WHERE Accounts.AccountId = @AccountId
GO

BEGIN TRAN
EXEC dbo.usp_DepositMoney 1, 230
EXEC dbo.usp_DepositMoney 2, 2300
EXEC dbo.usp_DepositMoney 3, 1230
EXEC dbo.usp_DepositMoney 4, 5230
COMMIT TRAN
GO