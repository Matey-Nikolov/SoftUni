SELECT ProjectID, StartDate, EndDate,  udf_ProjectDurationWeeks(StartDate, EndDate) AS 'ProjectWeeks'
FROM Projects