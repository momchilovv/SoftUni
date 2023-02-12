SELECT FirstName, LastName, Manufacturer, Model, FlightHours
FROM PilotsAircraft
JOIN Pilots ON Pilots.Id = PilotsAircraft.PilotId
JOIN Aircraft ON Aircraft.Id = PilotsAircraft.AircraftId
WHERE FlightHours IS NOT NULL AND FlightHours <= 303
ORDER BY FlightHours DESC, FirstName;