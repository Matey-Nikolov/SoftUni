/*
CREATE PROCEDURE usp_AssignProject(@emloyeeId INT, @projectID INT)
AS 
BEGIN TRANSACTION

DECLARE @total INT = 
(
	SELECT COUNT(EmployeeID) 
	FROM EmployeesProjects
	WHERE = @emloyeeId
)

IF(@total >= 3)
BEGIN
	ROLLBACK
	RAISERROR('The employee has too many projects!', 16, 1)
	RETURN
END

COMMIT


EXECUTE usp_AssignProject 3, 2;
*/
/*
CREATE PROCEDURE usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN TRANSACTION

	DECLARE @employee INT = 
	(
		SELECT EmployeeID FROM Employees 
		WHERE EmployeeID = @emloyeeId
	)

	DECLARE @project INT = 
	(
		SELECT ProjectID FROM Projects
		WHERE ProjectID = @projectID
	)
	
	DECLARE @projectCount INT = 
	(
		SELECT COUNT(*) FROM EmployeesProjects
		WHERE ProjectID = @projectID
	)

IF(@projectCount > 3)
BEGIN
	ROLLBACK
	RAISERROR('The employee has too many projects!', 16, 1)
	RETURN
END

	INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
	VALUES(@emloyeeId, @projectID)
*/

CREATE PROCEDURE usp_AssignProject(@emloyeeId INT, @projectID INT)
AS
BEGIN TRANSACTION
INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
	VALUES(@emloyeeId, @projectID)
	IF((SELECT COUNT(EmployeeID) FROM EmployeesProjects WHERE EmployeeID = @emloyeeId) > 3)
	BEGIN
		ROLLBACK
		RAISERROR('The employee has too many projects!', 16, 1)
		RETURN
	END

COMMIT