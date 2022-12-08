CREATE TRIGGER tr_CreateTableLogs
ON Accounts
FOR UPDATE
AS
BEGIN
	DECLARE @account INT = (SELECT Id FROM inserted)
	DECLARE @oldSum DECIMAL(16, 2) =  (SELECT Balance FROM deleted)
	DECLARE @newSum DECIMAL(16, 2) =  (SELECT Balance FROM inserted)
	DECLARE @dataLog DATETIME2 = (SELECT GETDATE())

	INSERT INTO Logs(AccountId, OldSum, NewSum, UpdateDateOn)
	VALUES(@account, @oldSum, @newSum, @dataLog)

END
GO

SELECT * FROM Logs
UPDATE Accounts SET Balance += 5 WHERE Id = 1

--CREATE TABLE Logs
--(
--	Id INT PRIMARY KEY,
--	AccountId INT FOREIGN KEY REFERENCES Accounts(id),
--	OldSum DECIMAL(16, 2),
--	NewSum DECIMAL(16, 2),
--	UpdateDateOn DATETIME2
--)
--GO