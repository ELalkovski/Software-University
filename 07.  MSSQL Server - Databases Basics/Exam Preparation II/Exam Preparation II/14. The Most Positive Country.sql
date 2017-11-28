SELECT TOP 1 WITH TIES c.Name,
					   ISNULL(AVG(f.Rate), 0) AS [FeedBackRate]
  FROM Countries AS c
FULL JOIN Customers AS cu ON cu.CountryId = c.Id
FULL JOIN Feedbacks AS f ON f.CustomerId = cu.Id
GROUP BY c.Id, c.Name
ORDER BY AVG(f.Rate) DESC