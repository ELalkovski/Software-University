CREATE PROC usp_EmployeesBySalaryLevel (@levelOfSalary VARCHAR(10))
AS SELECT FirstName,
		  LastName FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary) = @levelOfSalary

EXEC dbo.usp_EmployeesBySalaryLevel 'High'