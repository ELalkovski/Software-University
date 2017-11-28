SELECT TOP 5
   e.EmployeeID, 
   e.JobTitle, 
   a.AddressId, 
   a.AddressText FROM Employees AS e
INNER JOIN Addresses AS a ON e.AddressID = a.AddressID
ORDER BY e.AddressID