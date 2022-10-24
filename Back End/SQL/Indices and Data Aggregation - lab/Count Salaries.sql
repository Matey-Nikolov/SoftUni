SELECT DepartmentId, COUNT(Salary) AS 'SalaryCount' FROM Employees
GROUP BY DepartmentId