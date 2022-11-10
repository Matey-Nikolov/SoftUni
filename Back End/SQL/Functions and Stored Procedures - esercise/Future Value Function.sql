CREATE FUNCTION ufn_CalculateFutureValue(@Sum MONEY, @Rate FLOAT, @NumberOfYears INT)
RETURNS MONEY AS
BEGIN
	RETURN @Sum * POWER(1 + @Rate, @NumberOfYears)
END