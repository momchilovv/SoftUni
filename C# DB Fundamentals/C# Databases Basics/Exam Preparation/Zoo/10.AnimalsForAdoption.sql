SELECT 
	a.[Name],
	YEAR(a.[BirthDate]) AS BirthYear,
	[at].AnimalType
FROM Animals AS a
JOIN AnimalTypes AS [at] ON a.AnimalTypeId = [at].Id
WHERE OwnerId IS NULL AND [at].AnimalType != 'Birds'
AND a.BirthDate >= DATEADD(YEAR, -4, '01/01/2022')
ORDER BY a.[Name];