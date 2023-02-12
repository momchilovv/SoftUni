CREATE FUNCTION udf_ClientWithCigars(@name VARCHAR(30))
RETURNS INT
AS 
BEGIN
	DECLARE @result INT;

	SET @result = (
		SELECT 
			COUNT(cc.ClientId)
		FROM ClientsCigars AS cc
		JOIN Clients AS c ON cc.ClientId = c.Id
		WHERE c.FirstName = @name
	);

	RETURN @result;
END;