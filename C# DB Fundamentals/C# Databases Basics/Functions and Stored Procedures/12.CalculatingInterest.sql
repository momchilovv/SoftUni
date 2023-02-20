CREATE PROC usp_CalculateFutureValueForAccount (@accountId INT, @interestRate FLOAT) 
AS
BEGIN
	SELECT a.Id AS [Account Id],
		   ah.FirstName AS [First Name],
		   ah.LastName AS [Last Name],
		   a.Balance,
		   dbo.ufn_CalculateFutureValue(balance, @interestRate, 5) AS [Balance in 5 years]
	FROM AccountHolders AS ah
	JOIN Accounts AS a ON ah.Id = a.Id
	WHERE a.Id = @accountId
END;