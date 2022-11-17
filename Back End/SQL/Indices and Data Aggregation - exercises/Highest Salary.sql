SELECT TOP(3) DepartmentID, Salary AS 'ThirdHighestSalary' FROM Employees
GROUP BY DepartmentID, Salary