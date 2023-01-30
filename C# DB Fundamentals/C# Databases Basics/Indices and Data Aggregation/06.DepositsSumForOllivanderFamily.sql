SELECT wd.DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits AS wd
GROUP BY DepositGroup, MagicWandCreator
HAVING MagicWandCreator = 'Ollivander Family';