CREATE PROCEDURE usp_AnimalsWithOwnersOrNot @AnimalName VARCHAR(30)
AS
BEGIN
	SELECT
		a.[Name],
		ISNULL(o.[Name], 'For adoption') AS OwnersName
	FROM Animals AS a
	LEFT JOIN Owners AS o ON o.Id = a.OwnerId
	WHERE a.[Name] = @AnimalName
END;