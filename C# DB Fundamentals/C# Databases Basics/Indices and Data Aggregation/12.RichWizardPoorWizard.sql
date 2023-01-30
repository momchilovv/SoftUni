SELECT SUM(SumDifference) AS SumDifference
FROM
(SELECT
FirstName AS [Host Wizard],
DepositAmount AS [Host Wizard Amount],
LEAD(FirstName) OVER(ORDER BY Id) AS [Guest Wizard],
LEAD(DepositAmount) OVER(ORDER BY Id) AS [Guest Wizard Amount],
DepositAmount - LEAD(DepositAmount) OVER(ORDER BY Id) AS [SumDifference]
FROM WizzardDeposits)
AS SumDifference;