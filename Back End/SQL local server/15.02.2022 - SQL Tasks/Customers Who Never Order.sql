SELECT Name AS 'Customers'
FROM Customers AS e
LEFT JOIN Orders AS d
ON e.Id = d.CustomerId
WHERE d.CustomerId IS NULL