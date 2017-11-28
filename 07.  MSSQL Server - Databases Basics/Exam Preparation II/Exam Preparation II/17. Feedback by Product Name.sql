CREATE FUNCTION udf_GetRating(@ProductName NVARCHAR(25))
RETURNS VARCHAR(9)
AS
BEGIN
DECLARE @AveraRate DECIMAL(4, 2) = (SELECT AVG(f.Rate)
	  FROM Feedbacks AS f
	FULL JOIN Products AS p ON p.Id = f.ProductId
	WHERE p.[Name] = @ProductName)
	IF (@AveraRate > 8)
	BEGIN
		RETURN 'Good'
	END
	ELSE IF (@AveraRate >= 5 AND @AveraRate <= 8)
	BEGIN
		RETURN 'Average'
	END
	ELSE IF (@AveraRate < 5)
	BEGIN
		RETURN 'Bad'
	END
	
	RETURN 'No rating'
END