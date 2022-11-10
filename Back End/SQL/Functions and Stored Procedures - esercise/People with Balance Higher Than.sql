CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@number DECIMAL(13,2))
AS
BEGIN
	SELECT e.FirstName AS 'First Name', e.LastName AS 'Last Name' FROM AccountHolders AS e
	JOIN Accounts AS d
	ON e.Id = d.AccountHolderId
	WHERE Balance > @number
	GROUP BY e.FirstName, e.LastName
	ORDER BY [First Name], [Last Name]
END

EXEC usp_GetHoldersWithBalanceHigherThan 200