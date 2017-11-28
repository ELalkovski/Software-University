SELECT TOP 5
	   c.CountryName,
	   r.RiverName FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
LEFT JOIN Continents AS cont ON cont.ContinentCode = c.ContinentCode
WHERE cont.ContinentName = 'Africa'
ORDER BY c.CountryName