SELECT FirstName, LastName, HireDate, Departments.[Name] AS DeptName
FROM Employees
JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
WHERE HireDate > '1999.01.01' AND Departments.[Name] IN ('Sales', 'Finance')
ORDER BY HireDate;