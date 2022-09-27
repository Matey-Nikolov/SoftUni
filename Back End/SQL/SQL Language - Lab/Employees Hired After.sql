SELECT FirstName, LastName, HireDate, d.Name AS 'DeptName'
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE e.HireDate >= '1.1.1999' AND d.DepartmentID IN (3, 10)
ORDER BY e.HireDate
