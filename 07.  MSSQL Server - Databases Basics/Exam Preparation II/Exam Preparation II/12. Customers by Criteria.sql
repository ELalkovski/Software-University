SELECT FirstName,
	   Age,
	   PhoneNumber 
 FROM Customers
 WHERE Id IN (SELECT c.Id FROM Customers AS c
			  WHERE c.FirstName LIKE '%an%' AND c.Age >= 21)
	 OR Id IN (SELECT coc.Id FROM Customers AS coc
			   JOIN Countries AS cc ON cc.Id = coc.CountryId
			   WHERE coc.PhoneNumber LIKE '%38' AND cc.[Name] <> 'Greece')
 ORDER BY FirstName, Age DESC