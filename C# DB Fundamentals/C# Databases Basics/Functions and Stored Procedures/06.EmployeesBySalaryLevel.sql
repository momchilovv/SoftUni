CREATE PROCEDURE usp_EmployeesBySalaryLevel(@SalaryLevel VARCHAR(20))
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
END;