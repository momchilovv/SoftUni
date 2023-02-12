SELECT TOP (5)
	o.[Name],
	COUNT(o.Id) AS CountOfAnimals
FROM Owners AS o
JOIN Animals AS a ON a.OwnerId = o.Id
GROUP BY o.Id, o.[Name]
ORDER BY COUNT(a.Id) DESC, o.[Name];