CREATE PROC usp_WithdrawMoney (@AccountId INT, @MoneyAmount MONEY)
AS
BEGIN
	DECLARE @CurrentAmount MONEY = ( 
	SELECT Balance FROM Accounts
	 WHERE Id = @AccountId)
	  
	BEGIN TRANSACTION
	IF (@MoneyAmount < 0.0000)
	BEGIN
		RAISERROR('Amount must be positive number', 16, 1)
		RETURN
	END

	UPDATE Accounts
	SET Balance -= @MoneyAmount
	WHERE Id = @AccountId

	IF (@CurrentAmount < 0)
	BEGIN
		RAISERROR('Ammount cannot be negative number', 16, 1)
		ROLLBACK
		RETURN
	END

	COMMIT
END