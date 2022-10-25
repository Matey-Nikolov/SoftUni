CREATE PROCEDURE usp_GetTownsStartingWith(@input CHAR = 'b')
AS
SELECT Towns.Name FROM Towns
WHERE Towns.Name LIKE @input