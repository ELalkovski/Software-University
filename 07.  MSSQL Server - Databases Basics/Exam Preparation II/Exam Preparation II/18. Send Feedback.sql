CREATE PROC usp_SendFeedback 
(@CustomerId INT, @ProductId INT, @Rate DECIMAL(4, 2), @Description NVARCHAR(255))
AS
BEGIN
   BEGIN TRANSACTION
	INSERT INTO Feedbacks (CustomerId, ProductId, Rate, [Description]) VALUES
	(@CustomerId, @ProductId, @Rate, @Description)

DECLARE @FeedBacksCount INT = (SELECT COUNT(*) FROM Feedbacks WHERE 
							   CustomerId = @CustomerId AND ProductId = @ProductId)
	 IF(@FeedBacksCount > 3)
	 BEGIN
		RAISERROR('You are limited to only 3 feedbacks per product!', 16, 1)
		ROLLBACK
		RETURN
	 END

	 COMMIT
END