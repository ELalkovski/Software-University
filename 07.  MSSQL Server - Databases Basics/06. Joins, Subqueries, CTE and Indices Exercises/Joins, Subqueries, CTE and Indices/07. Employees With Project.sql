SELECT TOP 5
	  e.EmployeeID,
	  e.FirstName,
	  p.Name FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.EndDate IS NULL
AND p.StartDate > '08/13/2002'
ORDER BY e.EmployeeID