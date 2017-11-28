CREATE TRIGGER tr_RestrictHighLevelItems ON UserGameItems
FOR INSERT
AS
IF (EXISTS (
	SELECT * FROM UsersGames AS ug
	JOIN UserGameItems AS ugi ON ug.GameId = ugi.UserGameId
	JOIN Items AS i ON i.Id = ugi.ItemId
	WHERE i.MinLevel > ug.Level))
BEGIN
	RAISERROR('Item Level is Higher Than Character Level', 16, 1)
	ROLLBACK
	RETURN
END

UPDATE UsersGames
SET Cash += 50000
WHERE UserId IN
(SELECT u.Id FROM UsersGames AS ug
JOIN Users AS u ON u.Id = ug.UserId
WHERE u.Username IN ('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos'))
AND
GameId IN
(SELECT ug.GameId FROM UsersGames AS ug
 JOIN Games AS g ON g.Id = ug.GameId
 WHERE g.Name = 'Bali'	
)
