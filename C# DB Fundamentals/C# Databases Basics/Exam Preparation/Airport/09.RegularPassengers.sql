SELECT 
	p.FullName,
	COUNT(a.Id) AS CountOfAircraft,
	SUM(fd.TicketPrice) AS TotalPayed
FROM Passengers AS p
JOIN FlightDestinations AS fd ON p.Id = fd.PassengerId
JOIN Aircraft AS a ON fd.AircraftId = a.Id
WHERE SUBSTRING(p.FullName, 2, 1) = 'a'
GROUP BY p.Id, p.FullName
HAVING COUNT(a.Id) > 1
ORDER BY p.FullName;