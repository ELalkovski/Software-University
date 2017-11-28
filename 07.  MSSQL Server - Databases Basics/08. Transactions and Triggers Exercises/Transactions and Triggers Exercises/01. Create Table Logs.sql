CREATE TRIGGER tr_AccountsUpdate ON Accounts 
FOR UPDATE
AS
BEGIN
	INSERT INTO Logs (AccountId, OldSum, NewSum)
	SELECT deleted.Id,
		   deleted.Balance,
		   inserted.Balance FROM inserted
	INNER JOIN deleted ON deleted.Id = inserted.Id
END