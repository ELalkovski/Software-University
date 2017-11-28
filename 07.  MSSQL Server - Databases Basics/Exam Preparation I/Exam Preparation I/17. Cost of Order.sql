CREATE FUNCTION udf_GetCost (@JobId INT)
RETURNS DECIMAL(15, 2)
AS
BEGIN
DECLARE @Result DECIMAL(15, 2)
SET @Result = (
	SELECT 
	ISNULL(SUM(op.Quantity * p.Price), 0) FROM Jobs AS j
	LEFT JOIN Orders AS o ON o.JobId = j.JobId
	LEFT JOIN OrderParts AS op ON o.OrderId = op.OrderId
	LEFT JOIN Parts AS p ON p.PartId = op.PartId
	WHERE j.JobId = @JobId
	GROUP BY j.JobId)

	RETURN @Result
END


GO 

SELECT dbo.udf_GetCost(1) AS [DSFD]