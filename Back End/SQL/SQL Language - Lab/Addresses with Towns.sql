SELECT TOP 50
	e.FirstName,
	e.LastName,
	o.Name,
	a.AddressText
FROM Employees AS e 

JOIN Addresses AS a
ON a.AddressID = e.AddressID

JOIN Towns AS o
ON a.TownID = o.TownID

ORDER BY FirstName ASC, LastName ASC