SELECT DepartmentID, MAX(Salary) AS 'MaxSalary' FROM Employees
GROUP BY DepartmentID