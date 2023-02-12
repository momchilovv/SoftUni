SELECT 
	a.Id, 
	a.Manufacturer, 
	a.FlightHours, 
	COUNT(fd.Id) AS FlightDestinationsCount,
	ROUND(AVG(fd.TicketPrice), 2) AS AvgPrice
FROM Aircraft AS a
JOIN FlightDestinations as fd ON fd.AircraftId = a.Id
GROUP BY a.Id, a.Manufacturer, a.FlightHours
HAVING COUNT(fd.Id) > 1
ORDER BY 4 DESC, a.Id;