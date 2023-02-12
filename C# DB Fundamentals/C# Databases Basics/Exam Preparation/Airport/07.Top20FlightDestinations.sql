SELECT TOP (20) fd.Id AS DestinationId, fd.[Start], FullName, a.AirportName, TicketPrice
FROM FlightDestinations AS fd
JOIN Passengers AS p ON p.Id = fd.PassengerId
JOIN Airports AS a ON a.Id = fd.AirportId
WHERE DAY([Start]) % 2 = 0
ORDER BY TicketPrice DESC, AirportName;