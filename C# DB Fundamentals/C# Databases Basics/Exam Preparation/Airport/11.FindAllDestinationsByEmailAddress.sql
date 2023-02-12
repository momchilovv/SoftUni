CREATE FUNCTION udf_FlightDestinationsByEmail(@email VARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @countOfDestinations TINYINT;

	SET @countOfDestinations = (
		SELECT COUNT(p.Id)
		FROM Passengers AS p
		JOIN FlightDestinations AS fd ON p.Id = fd.PassengerId
		WHERE p.Email = @email
		GROUP BY p.Id
	)
	
	IF @countOfDestinations IS NULL
		SET @countOfDestinations = 0;

	RETURN @countOfDestinations
END;