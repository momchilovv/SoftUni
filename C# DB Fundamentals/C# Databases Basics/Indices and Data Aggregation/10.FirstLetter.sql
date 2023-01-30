SELECT DISTINCT SUBSTRING(FirstName, 1, 1) AS FirstLetter
FROM WizzardDeposits AS wd
GROUP BY FirstName, DepositGroup
HAVING wd.DepositGroup = 'Troll Chest'
ORDER BY FirstLetter;