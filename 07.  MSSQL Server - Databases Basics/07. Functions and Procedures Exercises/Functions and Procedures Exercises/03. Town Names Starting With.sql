CREATE PROC usp_GetTownsStartingWith (@startLetters NVARCHAR(MAX))
AS SELECT [Name] FROM Towns
WHERE ([Name] LIKE CONCAT(@startLetters, '%'))

EXEC dbo.usp_GetTownsStartingWit 'B'