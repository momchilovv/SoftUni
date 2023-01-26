SELECT TOP (3) e.EmployeeID, FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
WHERE ProjectID IS NULL
ORDER BY e.EmployeeID;