SELECT TOP 50
	  e.FirstName,
	  e.LastName,
	  t.Name,
	  a.AddressText FROM Employees AS e
INNER JOIN Addresses AS a ON e.AddressID = a.AddressID
INNER JOIN Towns AS t ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName