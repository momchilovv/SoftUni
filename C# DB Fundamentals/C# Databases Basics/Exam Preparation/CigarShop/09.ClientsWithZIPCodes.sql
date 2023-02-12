SELECT 
	CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
	a.Country,
	a.ZIP,
	CONCAT('$', MAX(ci.PriceForSingleCigar)) AS CigarPrice
FROM Clients AS c
JOIN Addresses AS a ON c.AddressId = a.Id
JOIN ClientsCigars AS cc ON cc.ClientId = c.Id
JOIN Cigars AS ci ON cc.CigarId = ci.Id
WHERE a.ZIP NOT LIKE '%[^0-9]%'
GROUP BY c.FirstName, c.LastName, a.Country, a.ZIP
ORDER BY FullName;