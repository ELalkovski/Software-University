SELECT p.PartId,
	   p.[Description],
	   SUM(pn.Quantity) AS [Required],
	   AVG(p.StockQty) AS [In Stock],
	   ISNULL(SUM(op.Quantity), 0) AS [Ordered]
 FROM Parts AS p
FULL JOIN PartsNeeded AS pn ON pn.PartId = p.PartId
FULL JOIN Jobs AS j ON j.JobId = pn.JobId
FULL JOIN Orders AS o ON o.JobId = j.JobId
FULL JOIN OrderParts AS op ON op.OrderId = o.OrderId
WHERE j.Status <> 'Finished'
GROUP BY p.PartId, p.Description
HAVING SUM(pn.Quantity) > ISNULL(SUM(op.Quantity), 0) + AVG(p.StockQty)
ORDER BY p.PartId

