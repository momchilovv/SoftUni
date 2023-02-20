CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@balance DECIMAL(18,2))
AS
BEGIN
	SELECT ah.FirstName, ah.LastName
	FROM AccountHolders AS ah
	JOIN Accounts AS a ON ah.Id = a.AccountHolderId
	GROUP BY ah.FirstName, ah.LastName
	HAVING SUM (a.Balance) > @balance
END;