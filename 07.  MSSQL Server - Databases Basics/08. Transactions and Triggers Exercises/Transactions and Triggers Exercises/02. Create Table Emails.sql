CREATE TRIGGER tr_LogsInsert ON Logs
FOR INSERT
AS
BEGIN
	INSERT INTO NotificationEmails (Recipient, [Subject], Body)
	SELECT inserted.AccountId,
		   CONCAT('Balance change for account: ', inserted.AccountId),
		   CONCAT('On ',GETDATE(), ' your balance was changed from ',inserted.OldSum, 
			' to ', inserted.NewSum, '.') FROM inserted
END

UPDATE Accounts
SET Balance = Balance - 10
WHERE Id = 1

SELECT * FROM NotificationEmails