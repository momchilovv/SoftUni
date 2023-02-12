SELECT
	f.Id,
	f.[Name],
	CONCAT(f.Size, 'KB') AS Size
FROM Files AS f
LEFT JOIN Files AS fl ON f.Id = fl.ParentId
WHERE fl.Id IS NULL
ORDER BY f.Id, f.[Name], f.Size DESC;