CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber (@number DECIMAL = 48100) /*48100 DECIMAL(18,4)*/
AS
SELECT FirstName, LastName FROM Employees
WHERE Salary >= @number