CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR, @word VARCHAR)
RETURNS BIT
AS
BEGIN
	DECLARE @currentIndex INT = 1;

	WHILE (@currentIndex <= LEN(@word))
		BEGIN
			DECLARE @currentChar CHAR = SUBSTRING(@word, @currentIndex, 1);

			IF CHARINDEX(@currentChar, @setOfLetters) = 0	
			BEGIN
				RETURN 0
			END
		
			SET @currentIndex +=1
		END
	RETURN 1
END;