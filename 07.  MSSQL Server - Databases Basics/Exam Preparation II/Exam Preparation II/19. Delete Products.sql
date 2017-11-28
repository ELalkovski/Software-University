CREATE TRIGGER tr_Delete ON Products
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @ProductId INT = (SELECT deleted.Id FROM deleted)

	DELETE FROM Feedbacks
	WHERE ProductId = @ProductId

	DELETE FROM ProductsIngredients
	WHERE ProductId = @ProductId

	DELETE FROM Products
	WHERE Id = @ProductId
END