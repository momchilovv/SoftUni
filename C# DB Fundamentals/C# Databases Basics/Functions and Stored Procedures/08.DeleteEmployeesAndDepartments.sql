CREATE PROCEDURE usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
BEGIN

	DECLARE @employeesId TABLE
	(
		Id int
	)

	INSERT INTO @employeesId
	SELECT e.EmployeeID
	FROM Employees AS e
	WHERE e.DepartmentID = @departmentId

	ALTER TABLE Departments
	ALTER COLUMN ManagerID int NULL

	DELETE FROM EmployeesProjects
	WHERE EmployeeID IN (SELECT Id FROM @employeesId)

	UPDATE Employees
	SET ManagerID = NULL
	WHERE ManagerID IN (SELECT Id FROM @employeesId)

	UPDATE Departments
	SET ManagerID = NULL
	WHERE ManagerID IN (SELECT Id FROM @employeesId)

	DELETE FROM Employees
	WHERE EmployeeID IN (SELECT Id FROM @employeesId)

	DELETE FROM Departments
	WHERE DepartmentID = @departmentId 

	SELECT COUNT(*) AS [Employees Count] FROM Employees AS e
	JOIN Departments AS d
	ON d.DepartmentID = e.DepartmentID
	WHERE e.DepartmentID = @departmentId;

END;