SELECT e.EmployeeID, e.FirstName, e.ManagerID, d.FirstName
FROM Employees AS e
JOIN Employees AS d
ON e.ManagerID = d.EmployeeID
WHERE e.ManagerID IN (3, 7)
ORDER BY E.EmployeeID ASC