CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName FROM Employees
WHERE DATEPART(year, HireDate) > 2000

GO

SELECT * FROM V_EmployeesHiredAfter2000