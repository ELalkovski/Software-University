USE Geography

SELECT PeakName, RiverName,
(LOWER(SUBSTRING(PeakName, 1, LEN(PeakName) - 1)) + LOWER(RiverName)) AS Mix 
  FROM Peaks, Rivers
  WHERE SUBSTRING(PeakName, LEN(PeakName), 1) =
		SUBSTRING(RiverName, 1, 1)
  ORDER BY Mix