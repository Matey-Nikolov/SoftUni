CREATE PROCEDURE usp_CalculateFutureValueForAccount(@AccountId INT, @InterestRate FLOAT)
AS
SELECT ah.Id AS 'Account Id', 
	ah.FirstName AS 'First Name', 
	ah.LastName AS 'Last Name', 
	a.Balance AS 'Current Balance',
	dbo.ufn_CalculateFutureValue(a.Balance, @InterestRate, 5) AS 'Balance in 5 years'
FROM AccountHolders As ah
JOIN Accounts As a
ON ah.Id = a.AccountHolderId
WHERE a.Id = @AccountId