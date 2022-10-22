SELECT e.DepartmentID, SUM(e.Salary) AS 'TotalSalary'
FROM Employees AS e
GROUP BY e.DepartmentID
HAVING SUM(e.Salary) >= 150000

/*SELECT SUM(e.Salary) AS 'Total',
	e.DepartmentID
FROM Employees AS e
GROUP By e.DepartmentID
HAVING SUM(e.Salary) >= 150000
*/

--SELECT * WHEN END CASE(select) and GROUP BY (CASE) - ex 9 