SELECT TOP(5) r.Name AS CategoryName, COUNT(r.Id) AS ReportNumber 
FROM Categories AS r
JOIN Reports AS e 
ON e.CategoryId = r.Id
GROUP BY r.Name
ORDER BY COUNT(e.Id) DESC, r.Name