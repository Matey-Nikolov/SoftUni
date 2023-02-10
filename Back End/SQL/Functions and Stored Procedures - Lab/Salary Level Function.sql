CREATE FUNCTION ufn_GetSalaryLevel(@Salary DECIMAL(18,4))
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(10);

	IF (@Salary < 30000)
	BEGIN
		SET @salaryLevel = 'Low'
	END
		ELSE IF(@Salary >= 30000 AND @Salary <= 50000)
	BEGIN
		SET @salaryLevel = 'Average'
	END
		ELSE IF(@Salary > 50000)
	BEGIN
		SET @salaryLevel = 'High'
	END

RETURN @salaryLevel;
END