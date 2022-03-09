SELECT Description, rep.Name AS CategoryName 
FROM Reports AS e
JOIN Categories AS rep 
ON e.CategoryId = rep.Id
WHERE CategoryId IS NOT NULL
ORDER BY Description, rep.Name