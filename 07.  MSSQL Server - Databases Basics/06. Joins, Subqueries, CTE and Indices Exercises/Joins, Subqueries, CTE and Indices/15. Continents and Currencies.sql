SELECT sel.ContinentCode,
	   sel.CurrencyCode,
	   sel.CurrencyUs AS [CurrencyUsage] 
	FROM (SELECT c.ContinentCode,
				 cr.CurrencyCode,
				 COUNT(cr.Description) AS [CurrencyUs],
				 DENSE_RANK() OVER 
				 (PARTITION BY c.ContinentCode 
				 ORDER BY COUNT(cr.CurrencyCode) DESC) AS rannk
				 FROM Currencies AS cr
			JOIN Countries AS c ON c.CurrencyCode = cr.CurrencyCode
			GROUP BY c.ContinentCode, cr.CurrencyCode
			HAVING COUNT(cr.Description) > 1
	) AS sel
WHERE sel.rannk = 1
ORDER BY sel.ContinentCode
