SELECT a.Name
FROM EmployeesEarning AS a, EmployeesEarning AS b
WHERE a.ManagerId = b.Id AND a.Salary > b.Salary