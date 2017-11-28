SELECT * INTO Temp15 FROM Employees
WHERE Salary > 30000

DELETE FROM Temp15
WHERE ManagerID = 42

UPDATE Temp15
SET Salary = Salary + 5000
WHERE DepartmentID = 1

SELECT DepartmentID,
   AVG(Salary) AS [AverageSalary]
  FROM Temp15
  GROUP BY DepartmentID
