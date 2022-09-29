SELECT TOP(5) e.EmployeeID, e.FirstName, d.Name AS 'ProjectName'
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS d ON ep.ProjectID = d.ProjectID
WHERE d.StartDate > '2002-08-13' AND d.EndDate IS NULL
ORDER BY e.EmployeeID ASC