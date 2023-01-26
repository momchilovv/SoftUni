SELECT c.CountryCode, COUNT (*) AS MountainRanges 
FROM MountainsCountries AS m
JOIN Countries AS c ON m.CountryCode = c.CountryCode
WHERE m.CountryCode IN ('US', 'BG', 'RU')
GROUP BY c.CountryCode;