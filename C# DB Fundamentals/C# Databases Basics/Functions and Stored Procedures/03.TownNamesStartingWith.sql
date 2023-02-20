CREATE PROCEDURE usp_GetTownsStartingWith (@StartsWith VARCHAR(50))
AS
BEGIN 
	SELECT [Name]
	FROM Towns
	WHERE [Name] LIKE @StartsWith + '%'
END;