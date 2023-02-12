SELECT  
	u.Username,
	AVG(f.Size)
FROM Commits AS c
JOIN Users AS u ON c.ContributorId = u.Id
JOIN Files AS f ON c.Id = f.CommitId
GROUP BY u.Username
ORDER BY AVG(f.Size) DESC, u.Username