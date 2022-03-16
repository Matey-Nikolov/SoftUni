SELECT CONCAT(emplo.FirstName, ' ', emplo.LastName) AS FullName, COUNT(DISTINCT repo.UserId) AS UsersCount
FROM Employees AS emplo
LEFT JOIN Reports AS repo 
ON repo.EmployeeId = emplo.Id
GROUP BY CONCAT(emplo.FirstName, ' ', emplo.LastName)
ORDER BY UsersCount DESC, FullName ASC