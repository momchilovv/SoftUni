SELECT TOP (2) wd.DepositGroup
FROM WizzardDeposits AS wd
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize);