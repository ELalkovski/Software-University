CREATE TRIGGER tr_DeleteEmployees ON Employees
FOR DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees (FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary)
	SELECT d.FirstName,
		   d.LastName,
		   d.MiddleName,
		   d.JobTitle,
		   d.DepartmentID,
		   d.Salary
	FROM deleted AS d
END