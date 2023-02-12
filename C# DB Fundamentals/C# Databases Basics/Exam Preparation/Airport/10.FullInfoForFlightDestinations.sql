SELECT 
	a.AirportName,
	CAST(fd.[Start] AS TIME) AS DayTime,
	fd.TicketPrice,
	p.FullName,
	ac.Manufacturer,
	ac.Model
FROM Airports AS a
JOIN FlightDestinations AS fd ON a.Id = fd.AirportId
JOIN Aircraft AS ac ON fd.AircraftId = ac.Id
JOIN Passengers AS p ON fd.PassengerId = p.Id
WHERE CAST(fd.[Start] AS TIME) BETWEEN '06:00' AND '20:00' 
AND fd.TicketPrice > 2500
ORDER BY ac.Model;