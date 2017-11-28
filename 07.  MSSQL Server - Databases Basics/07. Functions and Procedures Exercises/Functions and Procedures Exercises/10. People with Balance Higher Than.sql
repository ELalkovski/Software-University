CREATE PROC usp_GetHoldersWithBalanceHigherThan (@Number MONEY)
AS 
BEGIN
SELECT ah.FirstName AS [First Name],
	   ah.LastName AS [Last Name]
 FROM AccountHolders AS ah
JOIN Accounts AS a ON a.AccountHolderId = ah.Id
GROUP BY ah.FirstName, ah.LastName
HAVING SUM(a.Balance) > @Number
END