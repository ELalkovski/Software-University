SELECT DepartmentID,
   MAX(Salary) AS [MaxSalary]
 FROM Employees AS XX
 GROUP BY DepartmentID
 HAVING NOT (MAX(Salary) >= 30000 AND MAX(Salary) <= 70000) 