SELECT ContinentCode, CurrencyCode, CurrencyUsage
FROM (
SELECT *, DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC)
AS [Rank]
FROM (
SELECT ContinentCode, CurrencyCode, COUNT (*) AS CurrencyUsage
FROM Countries
GROUP BY ContinentCode, CurrencyCode
HAVING COUNT (*) > 1) AS [CurrencyUsageQuery]
) AS Ranking
WHERE [Rank] = 1;