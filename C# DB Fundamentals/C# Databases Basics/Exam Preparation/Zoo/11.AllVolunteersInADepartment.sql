CREATE FUNCTION udf_GetVolunteersCountFromADepartment (@VolunteersDepartment VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @countOfVolunteers INT;

	SET @countOfVolunteers = (
		SELECT COUNT(v.Id)
		FROM Volunteers AS v
		JOIN VolunteersDepartments AS vd ON v.DepartmentId = vd.Id
		WHERE vd.DepartmentName = @VolunteersDepartment
	);

	IF @countOfVolunteers IS NULL
		SET @countOfVolunteers = 0;

	RETURN @countOfVolunteers;
END;