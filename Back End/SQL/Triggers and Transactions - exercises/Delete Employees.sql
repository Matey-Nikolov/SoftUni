/*
CREATE TABLE Deleted_Employees
(
	EmployeeId INT PRIMARY KEY IDENTITY,
	LastName VARCHAR(50),
    FirstName VARCHAR(50),
	MiddleName VARCHAR(50),
	JobTitle VARCHAR(255),
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
	Salary DECIMAL(15, 2)
)
*/

CREATE TRIGGER tr_DeletedEmployees
ON Employees
FOR DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees(FirstName, LastName, JobTitle, DepartmentId, Salary)
	SELECT FirstName, LastName, JobTitle, DepartmentId, Salary FROM deleted
END