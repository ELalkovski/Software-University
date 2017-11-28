SELECT f.ProductId,
	   CONCAT(c.FirstName, ' ', c.LastName) AS [CustomerName],
       ISNULL(f.[Description], '') AS [FeedbackDescription]
  FROM Feedbacks AS f
JOIN Customers AS c ON c.Id = f.CustomerId
WHERE f.CustomerId IN 
(SELECT CustomerId FROM Feedbacks
JOIN Customers AS c ON c.Id = f.CustomerId
GROUP BY CustomerId
HAVING COUNT(CustomerId) >= 3	
)
ORDER BY f.ProductId, [CustomerName], f.Id