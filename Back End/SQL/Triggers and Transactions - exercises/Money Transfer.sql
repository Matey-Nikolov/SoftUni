CREATE PROCEDURE usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(16, 4))
AS
BEGIN TRANSACTION

DECLARE @senderAccount INT = 
(
	SELECT Id 
	FROM Accounts
	WHERE Id = @SenderId
)

DECLARE @receiverAccount INT = 
(
	SELECT Id 
	FROM Accounts
	WHERE Id = @ReceiverId
)

IF(@senderAccount IS NULL OR @receiverAccount IS NULL)
BEGIN
	ROLLBACK
	RAISERROR('Account doesn''t exist!', 16, 1)
	RETURN
END

DECLARE @currentAmount DECIMAL = 
(
	SELECT Balance
	FROM Accounts
	WHERE Id = @senderAccount
)

IF(@currentAmount - @amount < 0)
BEGIN
	ROLLBACK
	RAISERROR('Insufficient funds!', 16, 2)
	RETURN
END

UPDATE Accounts SET Balance -= @amount WHERE Id = @senderAccount

UPDATE Accounts SET Balance += @amount WHERE Id = @receiverAccount

COMMIT

EXECUTE usp_TransferMoney 5, 25;