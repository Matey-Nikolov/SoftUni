SELECT Description, FORMAT(OpenDate, 'dd-MM-yyyy') AS OpenDate 
FROM Reports AS d 
WHERE EmployeeId IS NULL
ORDER BY d.OpenDate, Description