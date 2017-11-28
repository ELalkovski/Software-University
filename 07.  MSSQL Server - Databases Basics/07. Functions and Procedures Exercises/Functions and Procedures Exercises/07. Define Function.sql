CREATE FUNCTION ufn_IsWordComprised(@SetOfLetters NVARCHAR(MAX), @Word NVARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @Index INT = 1
	DECLARE @WordLength INT = LEN(@Word)
	DECLARE @CurrentLetter CHAR

	WHILE (@Index <= @WordLength)
	BEGIN
		SET @CurrentLetter = SUBSTRING(@Word, @Index,1)
		IF (CHARINDEX(@CurrentLetter, @SetOfLetters) > 0)
		BEGIN
			SET @Index += 1
		END
		ELSE
		BEGIN
			RETURN 0
		END
	END

	RETURN 1
END

GO

SELECT dbo.ufn_IsWordComprised('pppp', 'Guy')