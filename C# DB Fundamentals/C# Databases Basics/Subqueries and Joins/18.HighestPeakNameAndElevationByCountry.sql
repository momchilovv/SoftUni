SELECT TOP (5) Country,
ISNULL([Highest Peak Name], '(no highest peak)'),
ISNULL([Highest Peak Elevation], 0),
ISNULL(Mountain, '(no mountain)')
FROM (
SELECT c.CountryName AS Country, p.PeakName AS [Highest Peak Name],
p.Elevation AS [Highest Peak Elevation], m.MountainRange AS Mountain,
DENSE_RANK() OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS [Rank]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
LEFT JOIN Peaks AS p ON m.Id = p.MountainId
) AS [Ranking]
WHERE [Rank] = 1;