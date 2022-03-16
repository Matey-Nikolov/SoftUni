SELECT k.Username, cate.Name AS CategoryName FROM Reports AS rep
JOIN Categories AS cate 
ON cate.Id = rep.CategoryId
JOIN Users AS k 
ON k.Id = rep.UserId
WHERE DATEPART(Day, k.Birthdate) = DATEPART(Day, rep.OpenDate)
ORDER BY k.Username, cate.Name