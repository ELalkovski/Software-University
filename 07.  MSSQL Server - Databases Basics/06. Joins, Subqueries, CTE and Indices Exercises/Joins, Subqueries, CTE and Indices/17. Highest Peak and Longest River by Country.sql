SELECT TOP 5 
           c.CountryName,
	   MAX(p.Elevation) AS [HighestPeakElevation],
	   MAX(r.Length) AS [LongestRiverLength] FROM Countries AS c
FULL JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
FULL JOIN Peaks AS p ON p.MountainId = mc.MountainId
FULL JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
FULL JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY MAX(p.Elevation) DESC, MAX(r.Length) DESC, c.CountryName