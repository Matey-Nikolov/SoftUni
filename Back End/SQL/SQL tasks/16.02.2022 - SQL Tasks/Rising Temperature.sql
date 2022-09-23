SELECT a.Id 
FROM Weather a
JOIN Weather e
ON  DATEDIFF(DAY, e.recordDate, a.recordDate) = 1
WHERE a.Temperature > e.Temperature