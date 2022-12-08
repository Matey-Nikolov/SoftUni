CREATE PROCEDURE usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(16, 4))
AS
BEGIN TRANSACTION

IF(@MoneyAmount < 0)
BEGIN
	ROLLBACK
	RAISERROR('invalid input!', 16, 1)
	RETURN
END

UPDATE Accounts 
SET Balance += @MoneyAmount 
WHERE Id = @AccountId

COMMIT

EXECUTE usp_DepositMoney 1, 10;