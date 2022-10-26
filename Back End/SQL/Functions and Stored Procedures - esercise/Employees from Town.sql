CREATE PROCEDURE usp_GetEmployeesFromTown (@townName NVARCHAR(30))
AS
SELECT FirstName, LastName FROM Employees
JOIN Addresses
ON Employees.AddressID = Addresses.AddressID
JOIN Towns
ON Towns.TownID = Addresses.TownID
WHERE Towns.Name = @townName

EXEC dbo.usp_GetEmployeesFromTown 'Sofia'