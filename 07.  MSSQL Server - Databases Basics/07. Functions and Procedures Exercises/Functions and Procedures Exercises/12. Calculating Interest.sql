CREATE PROC usp_CalculateFutureValueForAccount (@AcountId INT, @InterestRate FLOAT)
AS
BEGIN
	SELECT ah.Id AS [Account Id],
		   ah.FirstName AS [First Name],
		   ah.LastName AS [Last Name],
		   a.Balance AS [Current Balance],
		   dbo.ufn_CalculateFutureValue(a.Balance, @InterestRate, 5) AS [Balance in 5 years]
      FROM AccountHolders AS ah
JOIN Accounts AS a ON a.AccountHolderId = a.Id
WHERE ah.Id = @AcountId
END

GO

EXEC dbo.usp_CalculateFutureValueForAccount 1, 0.1
