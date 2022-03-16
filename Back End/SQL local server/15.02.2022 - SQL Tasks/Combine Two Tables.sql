SELECT d.FirstName AS 'FirstName', d.LastName AS 'LastName', City, State 
FROM Address AS e
JOIN Person AS d
ON d.PersonId = e.PersonId