SELECT wd.DepositGroup, wd.MagicWandCreator, MIN(DepositCharge)
FROM WizzardDeposits AS wd
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup;