CREATE FUNCTION ufn_GetSalaryLevel (@salary DECIMAL(18,4))
RETURNS VARCHAR(10)
AS
BEGIN
	IF (@salary < 30000)
	BEGIN
		RETURN 'Low'
	END
	ELSE IF (@salary >= 30000 AND @salary <= 50000)
	BEGIN
		RETURN 'Average'
	END

	RETURN 'High'
END 