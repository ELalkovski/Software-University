SELECT TOP 5
	   c.CountryName AS [Country],
	   CASE
		   WHEN p.PeakName IS NULL THEN '(no highest peak)'
		   ELSE p.PeakName
	   END AS [HighestPeakName],
	   CASE
		   WHEN p.Elevation IS NULL THEN 0
		   ELSE MAX(p.Elevation)
	   END AS [HighestPeakElevation],
	   CASE
		   WHEN m.MountainRange IS NULL THEN '(no mountain)'
		   ELSE m.MountainRange
	   END AS [Mountain] FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p ON m.Id = p.MountainId
GROUP BY c.CountryName, p.PeakName, p.Elevation, m.MountainRange
ORDER BY c.CountryName, p.PeakName