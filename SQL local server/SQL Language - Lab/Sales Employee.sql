SELECT EmployeeID, FirstName, LastName, d.Name AS 'DepartmentName'
FROM Employees AS e
JOIN Departments AS d
ON d.DepartmentID = e.DepartmentID
WHERE e.DepartmentID = 3
ORDER BY EmployeeID