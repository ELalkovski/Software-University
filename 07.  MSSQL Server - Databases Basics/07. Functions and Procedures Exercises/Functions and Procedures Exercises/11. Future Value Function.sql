ALTER FUNCTION ufn_CalculateFutureValue 
(@InitialSum MONEY, @InterestRate FLOAT, @Years INT)
RETURNS DECIMAL(15,4)
AS
BEGIN
	DECLARE @Result DECIMAL(15,4)
	SET @Result = (@InitialSum * (POWER((1 + @InterestRate), @Years)))
	RETURN @Result
END

GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)