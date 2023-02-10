SELECT Salary,
	dbo.ufn_GetSalaryLevel(Salary) AS 'Salary Level'
FROM Employees