SELECT 
	v.[Name],
	v.PhoneNumber,
	TRIM(REPLACE(REPLACE(v.[Address], 'Sofia', ''), ',', ''))
FROM Volunteers AS v
JOIN VolunteersDepartments AS vd ON v.DepartmentId = vd.Id
WHERE vd.DepartmentName = 'Education program assistant'
AND v.[Address] LIKE '%Sofia%'
ORDER BY v.[Name];