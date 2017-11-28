SELECT c.CountryCode,
	   COUNT(m.MountainRange) FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains AS m ON m.Id = mc.MountainId
GROUP BY c.CountryCode
HAVING c.CountryCode = 'BG' 
	OR c.CountryCode = 'US'
	OR c.CountryCode = 'RU'