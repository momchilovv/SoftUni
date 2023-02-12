SELECT TOP (5)
	r.Id,
	r.[Name],
	COUNT(c.Id) AS Commits
FROM RepositoriesContributors AS rc
JOIN Users AS u ON u.Id = rc.ContributorId
JOIN Repositories AS r ON r.Id = rc.RepositoryId
JOIN Commits AS c ON c.RepositoryId = r.Id
GROUP BY rc.RepositoryId, r.Id, r.[Name]
ORDER BY COUNT(c.Id) DESC, r.Id, r.[Name]; 