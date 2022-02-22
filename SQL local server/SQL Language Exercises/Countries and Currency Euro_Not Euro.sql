SELECT CountryName, CountryCode, d.Description
FROM Countries AS e
JOIN Currencies AS d
ON e.CurrencyCode = d.Description
WHERE e.CurrencyCode = 'Euro'