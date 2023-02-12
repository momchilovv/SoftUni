CREATE PROCEDURE usp_SearchForFiles(@fileExtension VARCHAR(10))
AS 
BEGIN 
	SELECT
		f.Id,
		f.[Name],
		CONCAT(f.Size, 'KB')
	FROM Files AS f
	WHERE f.[Name] LIKE CONCAT('%', @fileExtension)
	ORDER BY f.Id, f.[Name], f.Size DESC;
END;