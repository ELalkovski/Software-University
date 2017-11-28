CREATE PROC usp_DepositMoney (@AccountId INT, @MoneyAmount MONEY)
AS 
BEGIN
	BEGIN TRANSACTION
	IF (@MoneyAmount < 0.0000)
	BEGIN
		RAISERROR('Deposit must be a positive number', 16, 1)
		RETURN
	END

	UPDATE Accounts
	SET Balance += @MoneyAmount
	WHERE Id = @AccountId	

	COMMIT
END