SELECT DepartmentID, MIN(Salary) AS 'MinSalary' FROM Employees
GROUP BY DepartmentID