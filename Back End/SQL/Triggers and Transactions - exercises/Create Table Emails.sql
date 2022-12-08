/*
CREATE TABLE NotificationEmails
(
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT FOREIGN KEY REFERENCES Accounts(id),
	[Subject] NVARCHAR(50) NOT NULL,
	Body NVARCHAR(70)
)

CREATE TRIGGER tr_NotificationEmails
ON Logs
AFTER INSERT
AS
BEGIN
	INSERT INTO NotificationEmails(Recipient, [Subject], Body)
	VALUES
	(	
		(SELECT Id FROM inserted), 
		CONCAT('Balance change for account: ', (SELECT Id FROM inserted)),
		CONCAT('On ', (SELECT GETDATE() FROM inserted), 'your balance was changed from ', (SELECT OldSum FROM Logs),' to ',(SELECT NewSum FROM Logs), '.')
	)
END

UPDATE Accounts SET Balance += 5 WHERE Id = 1
*/

CREATE TRIGGER tr_NotificationEmails
ON Logs
FOR INSERT
AS
BEGIN
	DECLARE @accountId INT = (SELECT TOP(1) AccountId FROM inserted)
	DECLARE @oldSum DECIMAL(15, 2) = (SELECT TOP(1) OldSum FROM inserted)
	DECLARE @newSum DECIMAL(15, 2) = (SELECT TOP(1) NewSum FROM inserted)

	INSERT INTO NotificationEmails(Recipient, [Subject], Body)
	VALUES
	(
		@accountId, 'Balance change for account: ' + CAST(@accountId AS VARCHAR(20)),
		'On' + CONVERT(VARCHAR(20), GETDATE()) + 'your balance was changed from' +
		CAST(@oldSum AS VARCHAR(20)) + ' to ' + CAST(@newSum AS VARCHAR(20)) + '.'
	)

END

UPDATE Accounts SET Balance += 110 WHERE id = 1