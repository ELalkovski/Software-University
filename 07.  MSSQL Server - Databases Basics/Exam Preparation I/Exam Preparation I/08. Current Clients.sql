SELECT CONCAT(c.FirstName, ' ', c.LastName) AS [Client],
	   DATEDIFF(DAY, j.IssueDate, '04-24-2017') AS [Days going],
	   j.Status FROM Clients AS c
JOIN Jobs AS j ON c.ClientId = j.ClientId
WHERE j.Status <> 'Finished'
ORDER BY [Days going] DESC