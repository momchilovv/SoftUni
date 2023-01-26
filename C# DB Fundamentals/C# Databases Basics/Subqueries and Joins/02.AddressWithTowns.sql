SELECT TOP (50) FirstName, LastName, Towns.[Name], Addresses.AddressText
FROM Employees
JOIN Addresses ON Employees.AddressID = Addresses.AddressID
JOIN Towns ON Addresses.TownID = Towns.TownID
ORDER BY FirstName, LastName;