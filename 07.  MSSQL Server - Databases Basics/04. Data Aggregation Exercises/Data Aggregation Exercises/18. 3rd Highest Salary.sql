SELECT DepartmentID, Salary AS [ThirdHighestSalary] FROM
(
	SELECT DepartmentID,
	MAX(Salary) AS Salary,
	DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS RANK 
	FROM Employees
	GROUP BY DepartmentID, Salary
) AS [ThirdHighestSalary]
WHERE RANK = 3