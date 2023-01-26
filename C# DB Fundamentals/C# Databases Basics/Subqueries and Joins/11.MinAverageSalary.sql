WITH DepartmentAverageSalary AS (
SELECT DepartmentID, AVG(Salary) AS AvgSalary
FROM Employees
GROUP BY DepartmentID
)
SELECT MIN(AvgSalary) AS MinAverageSalary
FROM DepartmentAverageSalary;