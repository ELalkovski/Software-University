DECLARE @UserId INT = (SELECT Id FROM Users WHERE Username = 'Stamat')
DECLARE @GameId INT = (SELECT Id FROM Games WHERE Name = 'Safflower')
DECLARE @UserGameId INT = (SELECT Id FROM UsersGames WHERE UserId = @UserId AND GameId = @GameId)

BEGIN TRY
BEGIN TRANSACTION
UPDATE UsersGames
SET Cash -= (SELECT SUM(Price) FROM Items WHERE MinLevel IN (11, 12 ))
WHERE Id = @UserGameId

DECLARE @UserBalance DECIMAL(15,4) = 
(SELECT Cash FROM UsersGames WHERE Id = @UserGameId)

IF(@UserBalance < 0)
BEGIN
	ROLLBACK
	RETURN
END

INSERT INTO UserGameItems
SELECT Id, @UserGameId FROM Items
WHERE MinLevel IN (11, 12)
COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH

BEGIN TRY
BEGIN TRANSACTION
UPDATE UsersGames
SET Cash -= (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN 19 AND 21)
WHERE Id = @UserGameId

SET @UserBalance = (SELECT Cash FROM UsersGames WHERE Id = @UserGameId)

IF(@UserBalance < 0)
BEGIN
	ROLLBACK
	RETURN
END

INSERT INTO UserGameItems
SELECT Id, @UserGameId FROM Items
WHERE MinLevel BETWEEN 19 AND 21

COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH

SELECT i.[Name] AS [Item Name] 
FROM Items AS i
JOIN UserGameItems AS u ON i.Id = u.ItemId
WHERE u.UserGameId = @UserGameId
ORDER BY [Item Name]