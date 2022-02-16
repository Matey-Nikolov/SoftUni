SELECT e.name, d.bonus
FROM Employee AS e
LEFT JOIN Bonus AS d
ON e.empId = d.empId
WHERE bonus < 1000 OR d.bonus IS  NULL