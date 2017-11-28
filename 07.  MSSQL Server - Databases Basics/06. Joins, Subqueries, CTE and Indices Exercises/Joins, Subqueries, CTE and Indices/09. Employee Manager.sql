SELECT
	  e.EmployeeID,
	  e.FirstName,
	  e.ManagerID,
	  ej.FirstName FROM Employees AS e
JOIN Employees AS ej ON ej.EmployeeID = e.ManagerID
WHERE e.ManagerID = 3 OR e.ManagerID = 7
ORDER BY e.EmployeeID