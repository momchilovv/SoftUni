CREATE FUNCTION udf_AllUserCommits(@username INT)
RETURNS INT
AS
BEGIN
	DECLARE @commitsCount INT;

	SET @commitsCount = (
	SELECT 
		COUNT(c.Id) 	
	FROM Commits AS c
	JOIN Users AS u ON c.ContributorId = u.Id
	WHERE u.Username = @username
	);
	RETURN @commitsCount;
END;