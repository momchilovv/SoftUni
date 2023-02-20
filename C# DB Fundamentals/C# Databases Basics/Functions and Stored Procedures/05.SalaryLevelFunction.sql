CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(20)
AS
BEGIN
	DECLARE @level VARCHAR(100)

	IF @salary < 30000 SET @level = 'Low'
	ELSE IF @salary >= 30000 AND @salary <= 50000 SET @level = 'Average'
	ELSE SET @level = 'High'

	RETURN @level
END;